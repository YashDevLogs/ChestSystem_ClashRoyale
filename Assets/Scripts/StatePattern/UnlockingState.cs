using Assets.Scripts.Chest;

public class UnlockingState : IChestState
{
    private readonly ChestController _controller;

    public UnlockingState(ChestController controller)
    {
        _controller = controller;
    }

    public void EnterState()
    {
        _controller.chestView.InitialiseViewUIForUnlockingChest();
        _controller.StartTimer();
    }

    public void ExitState()
    {
    }

    public void UpdateState()
    {
    }

    public void OnClick()
    {
        // Handle click event for unlocking state
    }
}