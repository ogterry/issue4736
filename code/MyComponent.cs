
public sealed class FridgeComponent : Component
{
	[Property] public GameObject Fridge { get; set; }

	protected override void OnAwake()
	{
		if ( Fridge.Components.TryGet(out SkinnedModelRenderer model) )
		{
			model.Set( "open_01", true );
		}
	}
}
