using Assets.Scripts.Chest;

public class LockedState : IChestState
{
    private readonly ChestController _controller;

    public LockedState(ChestController controller)
    {
        _controller = controller;
    }

    public void EnterState()
    {
        _controller.chestView.InitialiseViewUIForLockedChest();
    }

    public void ExitState()
    {
    }

    public void UpdateState()
    {
    }

    public void OnClick()
    {
        // Handle click event for locked state
    }
}