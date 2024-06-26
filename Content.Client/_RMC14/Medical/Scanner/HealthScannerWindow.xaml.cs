﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Medical.Scanner;

[GenerateTypedNameReferences]
public sealed partial class HealthScannerWindow : DefaultWindow
{
    public HealthScannerWindow()
    {
        RobustXamlLoader.Load(this);
    }
}
