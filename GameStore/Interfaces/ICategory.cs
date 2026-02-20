using GameStore.Models;

namespace GameStore.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategory(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void UpdateAll(Category[] categories);

        void DeleteCategory(Category category);
    }
}
