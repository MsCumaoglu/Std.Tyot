using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ITagService : IService<Tag>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Tag isActiveTrue(Tag _model);
        Tag isActiveFalse(Tag _model);
    }
}
