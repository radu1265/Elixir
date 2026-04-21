static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
    // {
    //     throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
    // }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;
    // {
    //     throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    // }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;
    // {
    //     throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    // }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        return (petDogIsPresent && !archerIsAwake ) || (!petDogIsPresent && !knightIsAwake && !archerIsAwake && prisonerIsAwake);
    }
}
