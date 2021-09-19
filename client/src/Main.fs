module Main

open Fable.Core.JsInterop

importAll "./styles/main.scss"
importAll "./styles/tailwind.css"

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram App.init App.update App.render
//-:cnd:noEmit
#if DEBUG
|> Program.withDebugger
#endif
//+:cnd:noEmit
|> Program.withReactSynchronous "feliz-app"
|> Program.run