using InterfacesGame.Common.GameObjects;

namespace InterfacesGame.Common.Interfaces
{
    public interface IPlaceOnField
    {
        void RenderOnField(Map<int> coords);
    }
}