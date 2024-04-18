using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Testimonials : ViewComponent
    {
        TestimonialsManager testimonialsManager = new TestimonialsManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialsManager.TGetList();
            return View(values);
        }
    }
}
