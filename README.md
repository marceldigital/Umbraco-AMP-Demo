# Umbraco AMP Example
This is the example project that was used at the uWestFest 2017 AMP presentation.

## Areas of Note
Here are a couple areas that were touched on during the presentation.

### Umbraco AMP package (`MarcelDigital.Umbraco.Amp`)
This package was downloaded off of nuget [here](https://www.nuget.org/packages/MarcelDigital.Umbraco.Amp/).
#### AMP Template (`/Views/Amp.cshtml`)
This AMP template serves as a way to add an alternative template url to all content.
For example the content at `/something/my-content` will also now have an AMP url avaliable
to it at `/something/my-content/amp`.
#### AMP Layout (`/Views/Shared/_LayoutAmp.cshtml`)
AMP layout to get started creating AMP pages in.
#### AMP Controller (`MarcelDigital.Umbraco.Amp.Controllers.RenderAmpMvcController`)
This controller will act like the normal RenderMvcController except for the fact that it will
hijack the AMP route created by the AMP alternate template and search for the AMP view in a
different location. Views for the AMP alternate template route will be searched for in 
`/Views/Amp` and will try to match the template name to the document type that is being 
served. For example if you have a `TextPage` document type, it will search for a view at 
`/Views/Amp/TextPage.cshtml`. 


### Bundle Config (`/App_Start/BundleConfig.cs`)
This sets up the css files to be bundled up and be avaliable to inject inline to the AMP
page that is being built.

### Boostrapper (`/App_Start/Boostrapper.cs`)
This file inherits off of `IApplicationEventHandler` to hook into the Umbraco startup events.
In the bootstrapper, we register the custom bundles created in the `BundleConfig` and set the
custom AMP controller provided by the nuget package as the default controller.

### HtmlHelperExtensions (`/Extensions/HtmlHelperExtensions.cs`)
A couple of HTML extensions for the view which will allow the bundles that were created to be 
output inline in the HTML document to conform with the AMP standard.

### News Item AMP View (`/Views/Amp/NewsItem.cshtml`)
This is the custom AMP view for the `NewsItem` document type. An example of it in the 
content is `/example-content/news/colours/amp`.