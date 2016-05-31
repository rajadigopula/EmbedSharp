

namespace EmbedSharp

open FSharp.Data

type Providers() = 
    //Private function to load available providers dynamically
//    member GetAllAvailableProviders() = 
//        type oEmbedProviders = JsonProvider<"http://oembed.com/providers.json">
//        let providerUrls = oEmbedProviders.GetSamples()
//        providerUrls.


    member this.AvailableProvidersCount = 0
    //member this.
