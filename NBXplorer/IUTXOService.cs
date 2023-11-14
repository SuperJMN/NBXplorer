﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NBXplorer
{
	// Big hack to make CreatePSBT of MainController pick PostgresController as implementation for getting utxos.
	public interface IUTXOService
	{
		Task<IActionResult> GetUTXOs(string cryptoCode, DerivationStrategy.DerivationStrategyBase derivationStrategy);
	}
}
