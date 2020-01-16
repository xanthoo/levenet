using System.Drawing;

namespace ProP_Restaurant
{
    public interface Food
    {
        string GetName();
        bool IsAlcoholic();
        double GetPrice();
        void SetPrice(double value);
        Image GetThumbnail();

        string GetDetails();
    }
}