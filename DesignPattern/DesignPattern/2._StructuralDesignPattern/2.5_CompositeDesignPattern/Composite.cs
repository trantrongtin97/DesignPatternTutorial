using DesignPattern.StructuralDesignPattern.CompositeDesignPattern.Interface;

namespace DesignPattern.StructuralDesignPattern.CompositeDesignPattern
{
    public class Composite : IComponent
    {
        public string Name { get; set; }    
        public List<IComponent> components = new List<IComponent>();
        public Composite(string name) 
        {
            this.Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void ShowInfo()
        {
            foreach (var item in components)
            {
                item.ShowInfo();
            }
        }
    }
}
