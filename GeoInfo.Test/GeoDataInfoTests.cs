namespace GeoInfo.Test;

using GeoInfo;

[TestFixture]
public class GeoDataInfoTests {
	[Test]
	public void InfoIsAvailable() {
		Assert.That(GeoDataInfo.LastUpdated, Is.GreaterThan(DateTime.MinValue));
	}
}