﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Namespace Microsoft.VisualStudio.LanguageServices.UnitTests.CodeModel
    Partial Public MustInherit Class AbstractCodeModelObjectTests(Of TCodeModelObject As Class)

        Protected Class ImportData
            Public Property [Namespace] As String
            Public Property [Alias] As String
            Public Property Position As Object = 0
        End Class

    End Class
End Namespace
