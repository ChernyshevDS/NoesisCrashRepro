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
        private Visual rootVisual;
        private Border border;

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

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            rootVisual = FindRootVisual();
            border = (Border)this.GetTemplateChild("border");

            border.MouseLeftButtonDown += EmptyView_MouseLeftButtonDown;
        }

        private void EmptyView_MouseLeftButtonDown(object sender, MouseButtonEventArgs args)
        {
            var screenPos = args.GetPosition(null);
            var rootVisualPos = rootVisual.PointFromScreen(screenPos);
            
            HitTestResult result = null;

            VisualTreeHelper.HitTest(rootVisual,
                         target =>
                         {
                             var uiElement = target as UIElement;
                             if ((uiElement != null) && (!uiElement.IsHitTestVisible || !uiElement.IsVisible))
                                 return HitTestFilterBehavior.ContinueSkipSelfAndChildren;
                             else
                                 return HitTestFilterBehavior.Continue;
                         },
                         target =>
                         {
                             result = target;
                             return HitTestResultBehavior.Stop;
                         },
                         new PointHitTestParameters(rootVisualPos));

            UnityEngine.Debug.Log(result?.VisualHit?.ToString() ?? "<no hit>");
        }

        private Visual FindRootVisual() => (Visual)VisualTreeHelper.GetRoot(this);
    }
}
