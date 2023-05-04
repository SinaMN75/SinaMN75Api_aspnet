using Microsoft.AspNetCore.SignalR;

namespace SinaMN75Api.Hubs
{
    public class MoveViewHub : Hub
    {
        public async Task MoveViewFromServer(float newX, float newY)
        {
            await Clients.Others.SendAsync("RecieveNewPosition", newX, newY);

            Console.WriteLine($"Recieve psition from app: {newX} , {newY}");
        }
    }
}
