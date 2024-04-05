using Assets.Scripts.Chest;

public class UnlockedState : IChestState
{
    private readonly ChestController _controller;

    public UnlockedState(ChestController controller)
    {
        _controller = controller;
    }

    public void EnterState()
    {
        _controller.chestView.InitialiseViewUIForUnlockedChest();
    }

    public void ExitState()
    {
    }

    public void UpdateState()
    {
    }

    public void OnClick()
    {
        // Handle click event for unlocked state
    }
}