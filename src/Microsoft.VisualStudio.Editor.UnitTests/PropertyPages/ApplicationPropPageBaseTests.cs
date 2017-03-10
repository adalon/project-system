// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.Editors;
using Microsoft.VisualStudio.Editors.DesignerFramework;
using Microsoft.VisualStudio.Editors.ResourceEditor;

using Microsoft.VisualStudio.TestTools.MockObjects;
using Microsoft.VisualStudio.Shell.Interop;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Editors.UnitTests.DesignerFramework;
using Microsoft.VisualStudio.Editors.UnitTests.Mocks;
using System.CodeDom.Compiler;
using Microsoft.VisualBasic;
using Microsoft.CSharp;
using Microsoft.VisualStudio.Designer.Interfaces;
using Microsoft.VisualStudio.Editors.PropertyPages;

namespace Microsoft.VisualStudio.Editors.UnitTests.PropertyPageTests
{
    [TestClass]
    public class ApplicationPropPageBaseTests
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        private class ApplicationPropPageBaseSubclass : ApplicationPropPageBase
        {
            public ApplicationPropPageBaseSubclass() 
            {
            }
        }
        
        [TestMethod]
        public void Constructor()
        {
            ApplicationPropPageBaseSubclass x = new ApplicationPropPageBaseSubclass();
            
        }

    }
}
