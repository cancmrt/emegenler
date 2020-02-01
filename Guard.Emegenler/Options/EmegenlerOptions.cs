using Guard.Emegenler.Options.DefaultBehaviours;

namespace Guard.Emegenler.Options
{
    /// <summary>
    /// Contains Emegenler default options, this can be change in service builder
    /// </summary>
    public class EmegenlerOptions
    {
        public string PageAccessDeniedUrl { get; set; } = "/home";
        public ComponentDefaultBehaviour ComponentDefaultBehaviour { get; set; } = ComponentDefaultBehaviour.Show;
        public FormDefaultBehaviour FormDefaultBehaviour { get; set; } = FormDefaultBehaviour.ActionGranted;
        public InputDefaultBehaviour InputDefaultBehaviour { get; set; } = InputDefaultBehaviour.Editable;
        public ButtonDefaultBehaviour ButtonDefaultBehaviour { get; set; } = ButtonDefaultBehaviour.ActionGranted;
        public LinkDefaultBehaviour LinkDefaultBehaviour { get; set; } = LinkDefaultBehaviour.ActionGranted;
    }
}
