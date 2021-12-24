using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int id);   // rengin id sine göre getirme. expression bulunan Get() metoduyla çalışacak
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
