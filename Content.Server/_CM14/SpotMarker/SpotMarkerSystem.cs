using Content.Shared.Temperature;

namespace Content.Server._CM14.SpotMarker;

/// <summary>
/// This handles the activation of SpotMarkers
/// </summary>
public sealed class SpotMarkerSystem : EntitySystem
{
    public override void Update(float frameTime)
    {
        base.Update(frameTime);
        // i know its not the best implementation but it works RIIIIGHHHTTT (i'm gonna get yelled at in reviews for this...)

        var query = EntityQueryEnumerator<SpotMarkerComponent>();
        while (query.MoveNext(out var entity, out _))
        {
            var isHotEvent = new IsHotEvent();
            RaiseLocalEvent(entity, isHotEvent);

            if (!isHotEvent.IsHot)
            {
                RemComp<ActiveSpotMarkerComponent>(entity);
                return;
            }

            EnsureComp<ActiveSpotMarkerComponent>(entity);
        }
    }
}
