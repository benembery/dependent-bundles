dependent-bundles
=================

Bundle helpers that allow you to specify script dependencies in partials, display &amp; editor templates and have them rendered in the layout.

##Usage
Within a view, partial view, editor or display for you can use the following razor syntax to register a depedent script bundle.

    @Html.RegisterBundleDependency("~/bundles/dependency")
    
Then in your layout file you call the following method.

    @Html.RenderDependentScripts()
