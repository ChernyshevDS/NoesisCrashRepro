#if NOESIS
using Noesis;
#else
using System.Windows;
using System.Windows.Controls;
#endif

namespace Views
{
    public partial class EmptyView : UserControl
    {
        public EmptyView()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif
    }
}
