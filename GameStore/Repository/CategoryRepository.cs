using GameStore.Data;
using GameStore.Interfaces;
using GameStore.Models;

namespace GameStore.Repository
{
    public class CategoryRepository : ICategory
    {
        private ApplicationContext _context;

        public CategoryRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        //public void UpdateCategory(Category category)
        //{
        //    _context.Categories.Update(category);
        //    _context.SaveChanges();
        //}
        public Category GetCategory(int id)
        {
            return _context.Categories.FirstOrDefault(e => e.Id == id);
        }

        public void UpdateCategory(Category category)
        {
            Category category2 = GetCategory(category.Id);
            category2.Name = category.Name;
            category2.Description = category.Description;

            _context.SaveChanges();
        }


        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }

}

/*оптимизировать как продукт репозитори*/