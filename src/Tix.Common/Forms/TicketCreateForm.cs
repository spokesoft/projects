using Tix.Common.Infrastructure;

namespace Tix.Common.Forms;

public interface ITicketCreateForm
{
    
}

public abstract class BaseTicketCreateForm : BaseForm, ITicketCreateForm
{

}

public class TicketCreateForm : BaseForm
{

}