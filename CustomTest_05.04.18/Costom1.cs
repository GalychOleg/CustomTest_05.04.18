using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomTest_05._04._18
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomTest_05._04._18"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CustomTest_05._04._18;assembly=CustomTest_05._04._18"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Browse to and select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:Costom1/>
    ///
    /// </summary>
    public class Costom1 : Control
    {
        Button Button;
        public event EventHandler<RoutedEventArgs> BackClick;
        static Costom1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Costom1), new FrameworkPropertyMetadata(typeof(Costom1)));
        }
        
        public override void OnApplyTemplate()
        {
            Button = GetTemplateChild("Back") as Button;
            if (Button == null) throw new NullReferenceException();
            Button.Click += (s, e) => BackClick.Invoke(s, e);
            //first change in first branch
        }
        
    }
}
