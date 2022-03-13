using System;
using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;

namespace BizHawkToolbox
{
	public static class APIs
	{
		// hack-ish way to make these APIs available outside of the main tool form

		private static IMainFormForTools? mainFormForTools;
		private static ApiContainer? apiContainer;
		private static IEmuClientApi? clientApi;
		private static IEmulationApi? emulationApi;
		private static IGameInfoApi? gameInfoApi;
		private static ISaveStateApi? saveStateApi;

		public static IMainFormForTools MainFormForTools => Require(mainFormForTools);
		public static MainForm MainForm => (MainForm) MainFormForTools;

		public static ApiContainer ApiContainer => Require(apiContainer);

		// these seem to always be available even when no ROM is loaded
		public static IEmuClientApi Client => Require(clientApi);
		public static IEmulationApi Emulation => Require(emulationApi);
		public static IGameInfoApi GameInfo => Require(gameInfoApi);
		public static ISaveStateApi SaveState => Require(saveStateApi);

		public static Config Config => ((EmulationApi)Emulation).ForbiddenConfigReference;

		internal static void Update(ApiContainer container)
		{
			apiContainer = container;
			Fill(out clientApi);
			Fill(out emulationApi);
			Fill(out gameInfoApi);
			Fill(out saveStateApi);

			void Fill<T>(out T? field) where T : class, IExternalApi
			{
				if (apiContainer.Libraries.TryGetValue(typeof(T), out var api))
					field = api as T;
				else
					field = null;
			}
		}

		internal static void Update(IMainFormForTools mainForm)
		{
			mainFormForTools = mainForm;
		}

		private static T Require<T>(T? value) where T : class
		{
			return value ?? throw new InvalidOperationException($"{typeof(T).Name} is not available. Accessed before tool has been initialized?");
		}


		public static bool LoadRom(string path)
		{
			// Copy what the OpenRom API does because `IEmuClientApi.OpenRom` does not return the success bool
			// https://github.com/TASVideos/BizHawk/blob/b8f5050d6c426ba81ec1b1e1265b9b6cb9a40d3a/src/BizHawk.Client.Common/Api/Classes/EmuClientApi.cs#L141
			return MainFormForTools.LoadRom(
				path,
				new LoadRomArgs { OpenAdvanced = OpenAdvancedSerializer.ParseWithLegacy(path) }
			);
		}
	}
}