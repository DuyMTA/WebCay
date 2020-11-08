using System.Collections.Generic;
using System.Data;
using System.Linq;
using WenCay.Models.Entity;

namespace Model.Dao
{
    public class SanPhamDao
    {
        OnlineShopDbContext db = null;
        public SanPhamDao()
        {
            db = new OnlineShopDbContext();
        }
        public List<THELOAI> ListTheLoai()
        {
            return db.THELOAIs.ToList();
        }
        public IEnumerable<SANPHAM> ListSanPham(int id)
        {
            if (id == 0) { return db.SANPHAMs.OrderByDescending(x => x.TenSP).Take(9).ToList(); }
            else { return db.SANPHAMs.OrderByDescending(x => x.TenSP).Where(x => x.MaTheLoai == id).Take(9).ToList(); }
        }
        public SANPHAM SanPhamDetail(int id=1)
        {
            return db.SANPHAMs.Find(id.ToString());
        }
        public string TenTheLoai(int id=0)
        {
            if (id == 0) { return "Tất cả"; }
            var sanpham = db.SANPHAMs.Find(id.ToString());
            var theloai= db.THELOAIs.Find(sanpham.MaTheLoai);
            return theloai.TenTheLoai   ;
        }
        public List<SANPHAM> ListSanPhamTheLoaiPhanTrang(int id, ref int totalRecord,int page=1,int pageSize=2)
        {
            totalRecord = db.SANPHAMs.Count();
            if (id == 0) 
            {
                return db.SANPHAMs.OrderByDescending(x => x.TenSP).OrderByDescending(x=>x.TenSP).Skip((page-1)*pageSize).Take(pageSize).ToList(); 
            }
            else 
            {
                totalRecord = db.SANPHAMs.Where(x => x.MaTheLoai == id).Count();
                return db.SANPHAMs.OrderByDescending(x => x.TenSP).Where(x => x.MaTheLoai == id).OrderByDescending(x=>x.TenSP).Skip((page - 1) * pageSize).Take(pageSize).ToList(); 
            }
        }
        public IDictionary<THELOAI, int> DisplayCategory()
        {
            int soluong = 0;
            var theloai = db.THELOAIs.ToList();
            IDictionary<THELOAI, int> danhmuc = new Dictionary<THELOAI, int>();
            foreach (var item in theloai)
            {
                var sanphamX = db.DanhMucSanPhams.Find(item.MaTheLoai);
                if (sanphamX == null) { soluong = 0; }
                else { soluong = (int) sanphamX.Tong; }
                danhmuc.Add(item, soluong);
            }
            return danhmuc;
        }

    }
}
