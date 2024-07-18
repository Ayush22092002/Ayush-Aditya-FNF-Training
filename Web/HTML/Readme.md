# HTML Programming
- HTML stands for Hypertext Markup Language.
- Its a Text based Documents that are viewed on a thin software called Browsers. 
- Markups are arrow based braces that provide a sp format for the text that is placed inside it. 
- Markups provide a sp meaning on how the content has to be delivered on the Browser. 
- Markups ignore white spaces and place content in a linear fashion. 
- Markups have links which can direct to other documents. HyperText implies that the document would have links(Hyperlinks) that redirects to other linked documents for further viewing. 
- The Stds for the HTML is provided by a concortium of web designers and organizations called W3C.(World Wide Web). Latest version of HTML is HTML5.
- HTML 5 provides a major lift from the 4.0 version where the Web Apps can perform real time newer features relavent to the current technologies like Media Streaming, Geo Locations, Interactive web content, multi threading, local database support using SqlLite and many more.
- HTML is static. They dont need web servers to process them, a file can be viewed directly from the browser. 
- However, it is good approach to group the set of files together into a project and deploy it in a web server like IIS, Apache Tomcat, Express,  or WebSphere.
- As the content is delivered on the browser which is available in the client's(The person who views UR HTML Document) machine, U dont need any processing at the location end(Server side). 
- All HTML Content are saved as Text files with extension .html/.htm
--------------------------------------------------------------------
### HTML Basics
1. Files are saved with extension .htm
2. HTML5 Documents will have a Prologue called DocType which is html. 
3. Every Html Doc starts with &lt;html&gt; tag and ends with an end tag which is &lt;/html&gt; 
4. It shall have 2 sections, head and body. head section contains the information, metadata, title about the document and the body section contains the content of the document.  
5. A Sample Html Doc
```
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <article>
        <section>
            <header>
                <h1>Main Heading of the Document</h1>
            </header>
            <article>
                <h2>Sub Heading for the section</h2>
                <hr/>
                <div>
                    Represents Division within the document. 
                    <p>Can have paragraphs within the divs</p>
                </div>
            </article>
            <footer>
                <i>End of the section within the document</i>
            </footer>
        </section>
    </article>
</body>
</html>
```