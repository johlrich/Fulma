module Layouts.Columns.Types

type Model =
    { Intro : string
      BoxViewer : Viewer.Types.Model }

type Msg =
    | BoxViewerMsg of Viewer.Types.Msg
