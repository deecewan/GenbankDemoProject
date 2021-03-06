﻿// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Genbank

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    printfn "%s" Provider.Fungi.Genomes.``Cryptococcus_sp._JCM_24511``.``Annotation Hashes``.``Protein names last changed``
    printfn "%s" Genbank.Provider.Archaea.FTPUrl
    printfn "%s" Genbank.Provider.Other.Genomes.``synthetic_Mycoplasma_genitalium_JCVI-1.0``.``Annotation Hashes``.``Assembly accession``
    0 // return an integer exit code
