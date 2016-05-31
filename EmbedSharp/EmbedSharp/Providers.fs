

namespace EmbedSharp

open FSharp.Data
open System.Linq

//DTO for Json
type Provider( Name : string, ProviderUrl : string, Schemes : string[], oEmbedUrl : string, IsDiscoverable : Option<bool>, SupportedFormats : string[] ) = 
    member this.Name = Name
    member this.ProviderUrl = ProviderUrl
    member this.Schemes = Schemes
    member this.OEmbedUrl with get() = oEmbedUrl
    member this.IsDiscoverable = IsDiscoverable
    member this.SupportedFormats = SupportedFormats

type oEmbedProviders = JsonProvider<"http://oembed.com/providers.json">

type Providers() = 
    member this.GetAllAvailableProviders() = 
        let providerUrls = oEmbedProviders.Load("http://oembed.com/providers.json")
        providerUrls 
            |> Seq.map (fun x -> new Provider (Name = x.ProviderName, 
                                               ProviderUrl = x.ProviderUrl, 
                                               Schemes = x.Endpoints.FirstOrDefault().Schemes,
                                               oEmbedUrl = x.Endpoints.FirstOrDefault().Url,
                                               IsDiscoverable = x.Endpoints.FirstOrDefault().Discovery,
                                               SupportedFormats = x.Endpoints.FirstOrDefault().Formats) )
