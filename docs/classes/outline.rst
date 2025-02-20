.. include:: header.rst

.. _Outline:

================
Outline
================

*outline* (or "bookmark"), is a property of *Document*. If not *null*, it stands for the first outline item of the document. Its properties in turn define the characteristics of this item and also point to other outline items in "horizontal" or downward direction. The full tree of all outline items for e.g. a conventional table of contents (TOC) can be recovered by following these "pointers".

============================ ==================================================
**Method / Attribute**       **Short Description**
============================ ==================================================
:attr:`Outline.Down`         next item downwards
:attr:`Outline.Next`         next item same level
:attr:`Outline.Page`         page number (0-based)
:attr:`Outline.Title`        title
:attr:`Outline.Uri`          string further specifying outline target
:attr:`Outline.IsExternal`   target outside document
:attr:`Outline.IsOpen`       whether sub-outlines are open or collapsed
:attr:`Outline.Dest`         points to destination details object
============================ ==================================================

**Class API**

.. class:: Outline

   .. method:: Destination



   .. attribute:: Down

      The next outline item on the next level down. Is *null* if the item has no children.

      :type: :ref:`Outline`

   .. attribute:: Next

      The next outline item at the same level as this item. Is *null* if this is the last one in its level.

      :type: `Outline`

   .. attribute:: Page

      The page number (0-based) this bookmark points to.

      :type: int

   .. attribute:: Title

      The item's title as a string or *null*.

      :type: str

   .. attribute:: IsOpen

      Indicator showing whether any sub-outlines should be expanded (*true*) or be collapsed (*false*). This information is interpreted by PDF reader software.

      :type: bool

   .. attribute:: IsExternal

      A bool specifying whether the target is outside (*true*) of the current document.

      :type: bool

   .. attribute:: Uri

      A string specifying the link target. The meaning of this property should
      be evaluated in conjunction with property `IsExternal`:
      
      *
        `IsExternal` is true: `Uri` points to some target outside the current
        PDF, which may be an internet resource (`Uri` starts with "http://" or
        similar), another file (`Uri` starts with "file:" or "file://") or some
        other service like an e-mail address (`Uri` starts with "mailto:").

      *
        `IsExternal` is false: `Uri` will be `null` or point to an
        internal location. In case of PDF documents, this should either be
        *#nnnn* to indicate a 1-based (!) page number *nnnn*, or a named
        location. The format varies for other document types, for example
        "../FixedDoc.fdoc#PG_2_LNK_1" for page number 2 (1-based) in an XPS
        document.

      :type: str

   .. attribute:: Dest

      The link destination details object.

      :type: :ref:`linkDest`

.. include:: footer.rst
