
namespace Guard.Emegenler.FluentInterface.Policy.AccessStyles
{
    public interface IEmegenlerPolicyLinkAccess
    {
        void ActionGranted();
        void Readonly();
        void Hide();
    }
}
