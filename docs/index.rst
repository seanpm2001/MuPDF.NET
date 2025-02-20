.. meta::
   :description: MuPDF.NET Developer documentation.
   :keywords: mupdf, .net, pdf, document, api, split, merge, extract, view

:html_theme.sidebar_secondary.remove:

.. adds an engaging background image to the landing page
.. raw:: html

    <script>
        let bg = document.getElementsByClassName("bd-container")[0];
        bg.classList.add("landing-page");
        let div = document.createElement("div");
        bg.prepend(div);

        var spans = "";
        for (var i=0;i<11;i++) {
            spans += "<span></span>";
        }
        
        div.innerHTML = "<div class='bokeh-background'>"+spans+"</div>";

    </script>
        

Welcome to MuPDF.NET
==================================================

**MuPDF** for **.NET**.

- Fast rendering of **PDF** files
- Extract text and search **PDF** files
- **PDF** editing & annotations
- Get **PDF** metadata information
- Manage **PDF** passwords
- And more!


Developer documentation to help you get started 
--------------------------------------------------------------------------------------------------


.. adds a class to a section
.. rst-class:: hide-me

.. toctree::
    :caption: Welcome to PDF.co Documentation
    :maxdepth: 2

    getting-started/index.rst

.. include:: footer.rst


.. The home page doesn't need to show the feedback form in the footer
.. raw:: html

    <script>document.getElementById("feedbackHolder").style.display = "none";</script>
