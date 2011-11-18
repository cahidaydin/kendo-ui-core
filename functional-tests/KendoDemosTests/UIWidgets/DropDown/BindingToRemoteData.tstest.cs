using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using Telerik.WebAii.Controls.Xaml.Wpf;
using System.Windows.Forms;

namespace KendoDemosTests
{

    //
    // You can add custom execution steps by simply
    // adding a void function and decorating it with the [CodedStep] 
    // attribute to the test method. 
    // Those steps will automatically show up in the test steps on save.
    //
    // The BaseWebAiiTest exposes all key objects that you can use
    // to access the current testcase context. [i.e. ActiveBrowser, Find ..etc]
    //
    // Data driven tests can use the Data[columnIndex] or Data["columnName"] 
    // to access data for a specific data iteration.
    //
    // Example:
    //
    // [CodedStep("MyCustom Step Description")]
    // public void MyCustomStep()
    // {
    //        // Custom code goes here
    //      ActiveBrowser.NavigateTo("http://www.google.com");
    //
    //        // Or
    //        ActiveBrowser.NavigateTo(Data["url"]);
    // }
    //
        

    public class BindingToRemoteData : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion

        public string displayText;
        public string displayTextNew;

        [CodedStep(@"Wait for '250' msec.")]
        public void BindingToRemoteData_CodedStep()
        {

            // Wait for '250' msec.
            System.Threading.Thread.Sleep(250);
            
            displayText = Pages.BindingToRemoteData.ListItem.BaseElement.InnerText;
            //MessageBox.Show(displayText, displayTextNew);

        }

        [CodedStep(@"Wait for '250' msec.")]
        public void BindingToRemoteData_CodedStep1()
        {

            // Wait for '250' msec.
            System.Threading.Thread.Sleep(250);
            displayTextNew = Pages.BindingToRemoteData.ListItem.BaseElement.InnerText;
            Pages.BindingToRemoteData.ListItem.BaseElement.Refresh();
            Assert.AreNotEqual(displayText, displayTextNew);

        }

        //[CodedStep(@"Wait for 'TextContent' 'Contains' 'The Stars of Star Wars' on 'StarWarsSpan'")]
        //public void BindingToRemoteData_CodedStep()
        //{

        //    // Wait for 'TextContent' 'Contains' 'The Stars of Star Wars' on 'StarWarsSpan'
        //     System.Threading.Thread.Sleep(2000);
        //     displayText = Pages.BindingToRemoteData.StarWarsSpan.BaseElement.InnerText;
        //     MessageBox.Show(displayText, displayTextNew);

        //     System.Threading.Thread.Sleep(2000);
        //     ActiveBrowser.Window.SetFocus();
        //     Pages.BindingToRemoteData.SelectSpan.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
        //     Pages.BindingToRemoteData.SelectSpan.MouseClick();


        //     System.Threading.Thread.Sleep(2000);
        //     ActiveBrowser.Window.SetFocus();
        //     Pages.BindingToRemoteData.StarWarsListItem0.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementTopAtWindowTop);
        //     Pages.BindingToRemoteData.StarWarsListItem0.MouseClick();


        //     System.Threading.Thread.Sleep(2000);
        //     //Pages.BindingToRemoteData.StarWarsSpan.BaseElement.Refresh();
        //     //System.Threading.Thread.Sleep(1500);
        //     //displayTextNew = Pages.BindingToRemoteData.StarWarsSpan.BaseElement.InnerText;
        //     //MessageBox.Show(displayText, displayTextNew);

        //     //Pages.BindingToRemoteData.StarWarsSpan.BaseElement.AssertContent().InnerText(ArtOfTest.Common.StringCompareType.Contains, displayText);
        //     //Assert.AreNotEqual(displayText, displayTextNew);
        //}

      

            //Pages.BindingToRemoteData.StarWarsSpan.BaseElement.Wait.ForCondition((a_0, a_1) => ArtOfTest.Common.CompareUtils.StringCompare(a_0.TextContent, "The Stars of Star Wars", ArtOfTest.Common.StringCompareType.Contains), false, null, 10000);

    }

        

        

        
        
        // Add your test methods here...
 }

