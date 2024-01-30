﻿using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using SyncNBSParameters.Services;

namespace SyncNBSParameters.Commands;

[Transaction(TransactionMode.Manual)]
internal class CommandSettings : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        App.RevitDocument = commandData.Application.ActiveUIDocument.Document;
        App.CachedUiApp = commandData.Application;

        var newView = new Views.SettingsView();
        newView.ShowDialog();

        return Result.Succeeded;
    }
}