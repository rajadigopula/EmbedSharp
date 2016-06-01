// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

//#r @"C:\Users\pushparaj\Git Projects\EmbedSharp\EmbedSharp\packages\FSharp.Data.2.3.0\lib\net40\FSharp.Data.dll"
//open System
//open System.Linq
//open FSharp.Data
//// Define your library scripting code here
//
//type oEmbedProviders = JsonProvider<"http://oembed.com/providers.json">
//let providerUrls = oEmbedProviders.Load("http://oembed.com/providers.json")
//providerUrls.First().ProviderUrl;;
//providerUrls.First().Endpoints.First();;
//providerUrls.First().JsonValue;;
//providerUrls.First().ProviderName;;

#r @"C:\Users\pushparaj\Git Projects\EmbedSharp\EmbedSharp\EmbedSharp\bin\Debug\EmbedSharp.dll"

open EmbedSharp
open System
open System.Linq

let p = new Providers()
((((p.GetAllAvailableProviders()).First()).Schemes));;
(p.GetAllAvailableProviders()) |> Seq.map (fun x -> x.Schemes.[0]) |> Seq.iter Console.WriteLine ;;
p.GetAllAvailableProviders().Count();;