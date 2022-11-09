namespace Library
{
    public interface IComponenteVisitable
    {
        void Accept(IVisitor visitor);
    }
}