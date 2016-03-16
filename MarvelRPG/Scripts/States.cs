namespace States
{
    enum Combat
    {
        INIT, START, TURN, TARGET, RESOLVE, END,
    }

    enum Player
    {
        INIT, START, END,
    }

    enum Game
    {
        INIT, START, RUNNING, PAUSED, END
    }

}