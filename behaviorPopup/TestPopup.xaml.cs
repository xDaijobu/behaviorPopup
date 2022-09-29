using CommunityToolkit.Maui.Views;

namespace behaviorPopup;

public partial class TestPopup : Popup
{
	public TestPopup()
	{
		InitializeComponent();
	}
}


public class CustomBehavior : PlatformBehavior<Image>
{

#if ANDROID
    protected override void OnAttachedTo(Image bindable, Android.Views.View platformView)
#elif IOS
    protected override void OnAttachedTo(Image bindable, UIKit.UIView platformView)
#endif
    {
        System.Diagnostics.Debug.WriteLine("OnAttachedTo FIRE");

        base.OnAttachedTo(bindable, platformView);
    }
}