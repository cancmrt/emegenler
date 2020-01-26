
namespace Guard.Emegenler.FluentInterface.Policy.AccessStyles
{
    public interface IEmegenlerPolicyFormAccess
    {
        void ActionGranted();
        void Readonly();
        void Hide();
    }
}
