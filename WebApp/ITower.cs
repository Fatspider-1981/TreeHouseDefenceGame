namespace WebApp
{
    interface ITower
    {
        void FireOnInvaders(IInvader[] invaders);
        bool IsSuccessfullShot();
    }
}