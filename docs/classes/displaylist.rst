.. include:: header.rst

.. _DisplayList:

================
DisplayList
================

DisplayList is a list containing drawing commands (text, images, etc.). The intent is two-fold:

1. as a caching-mechanism to reduce parsing of a page
2. as a data structure in multi-threading setups, where one thread parses the page and another one renders pages. This aspect is currently not supported by PyMuPDF.

A display list is populated with objects from a page, usually by executing :meth:`Page.get_displaylist`. There also exists an independent constructor.

"Replay" the list (once or many times) by invoking one of its methods :meth:`~DisplayList.run`, :meth:`~DisplayList.get_pixmap` or :meth:`~DisplayList.get_textpage`.


================================= ============================================
**Method**                        **Short Description**
================================= ============================================
:meth:`~DisplayList.Run`          Run a display list through a device.
:meth:`~DisplayList.GetPixmap`    generate a pixmap
:meth:`~DisplayList.GetTextPage`  generate a text page
:attr:`~DisplayList.Rect`         mediabox of the display list
================================= ============================================


**Class API**

.. class:: DisplayList

   .. method:: DisplayList(Rect mediabox)

      Create a new display list.

      :arg mediabox: The page's rectangle.
      :type mediabox: :ref:`Rect`

      :rtype: *DisplayList*

   .. method:: Run(MuPDFDeviceWrapper device, Matrix matrix, Rect area)
    
      Run the display list through a device. The device will populate the display list with its "commands" (i.e. text extraction or image creation). The display list can later be used to "read" a page many times without having to re-interpret it from the document file.

      You will most probably instead use one of the specialized run methods below -- :meth:`get_pixmap` or :meth:`get_textpage`.

      :arg device: Device
      :type device: :ref:`Device`

      :arg matrix: Transformation matrix to apply to the display list contents.
      :type matrix: :ref:`Matrix`

      :arg area: Only the part visible within this area will be considered when the list is run through the device.
      :type area: :ref:`Rect`

   .. index::
      pair: matrix; DisplayList.GetPixmap
      pair: colorspace; DisplayList.GetPixmap
      pair: clip; DisplayList.GetPixmap
      pair: alpha; DisplayList.GetPixmap

   .. method:: GetPixmap(Matrix matrix = null, ColorSpace colorspace = null, float alpha=0, Rect clip=null)

      Run the display list through a draw device and return a pixmap.

      :arg matrix: matrix to use. Default is the identity matrix.
      :type matrix: :ref:`Matrix`

      :arg colorspace: the desired colorspace. Default is RGB.
      :type colorspace: :ref:`ColorSpace`

      :arg int alpha: determine whether or not (0, default) to include a transparency channel.

      :arg irect_like clip: restrict rendering to the intersection of this area with :attr:`DisplayList.Rect`.

      :rtype: :ref:`Pixmap`
      :returns: pixmap of the display list.

   .. method:: GetTextpage(int flags)

      Run the display list through a text device and return a text page.

      :arg int flags: control which information is parsed into a text page. Default value in PyMuPDF is `3 = TEXT_PRESERVE_LIGATURES | TEXT_PRESERVE_WHITESPACE`, i.e. :data:`ligatures` are **passed through**, white spaces are **passed through** (not translated to spaces), and images are **not included**. See :ref:`TextPreserve`.

      :rtype: :ref:`TextPage`
      :returns: text page of the display list.

   .. attribute:: Rect

      Contains the display list's mediabox. This will equal the page's rectangle if it was created via :meth:`Page.get_displaylist`.

      :type: :ref:`Rect`


.. include:: footer.rst
