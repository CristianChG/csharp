static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake != true) {
            return true;
        }
        return false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake == true && archerIsAwake == true && prisonerIsAwake == true){
            return true;
        }
        if(knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == false){
            return false;
        }
        if(knightIsAwake != true || archerIsAwake != true || prisonerIsAwake != true){
            return true;       
        }
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake != true && prisonerIsAwake == true){
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(archerIsAwake != true && petDogIsPresent == true){
            return true;
        }
        if(prisonerIsAwake == true && knightIsAwake != true && archerIsAwake != true){
            return true;
        }
        return false;
    }
}
