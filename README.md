dependent-bundles
=================

Bundle helpers that allow you to specify script dependencies in partials, display &amp; editor templates and have them rendered in the layout.

##Usage
Within a view, partial view, editor or display template you can use the following razor syntax to register a depedent script bundle.

    @Html.RegisterBundleDependency("~/your/bundle/url")
    
Then in your layout file you call the following method.

```html
<!DOCTYPE html>
<html>
    <head>
        <title>Dependent Bundles Demo Layout</title>
    </head>
    <body>
        <div class="container body-content">
        @RenderBody()
        </div>
        @Html.RenderDependentScripts()
    </body>
</html>
```
