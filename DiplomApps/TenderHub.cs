﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DiplomApps
{
	public class TenderHub : Hub
	{
		public async Task UpdateTender(Tender tender)
		{
			await Clients.All.SendAsync("UpdateTender", tender);
		}
	}
}
