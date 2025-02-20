.. include:: header.rst

.. _Identity:

============
Identity
============

Identity is a :ref:`Matrix` that performs no action -- to be used whenever the syntax requires a matrix, but no actual transformation should take place. It has the form *fitz.Matrix(1, 0, 0, 1, 0, 0)*.

Identity is a constant, an "immutable" object. So, all of its matrix properties are read-only and its methods are disabled.

If you need a **mutable** identity matrix as a starting point, use one of the following statements::

    >>> m = new Matrix(1, 0, 0, 1, 0, 0);  // specify the values
    >>> m = new Matrix(1, 1);              // use scaling by factor 1
    >>> m = new Matrix(0);                 // use rotation by zero degrees
    >>> m = new Matrix(fitz.Identity);     // make a copy of Identity

.. include:: footer.rst
