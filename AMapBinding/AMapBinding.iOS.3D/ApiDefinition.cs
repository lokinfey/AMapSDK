using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreLocation;
using MAMapKit;

namespace MAMapKit
{
	[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const AMapFoundationVersion;
		[Field("AMapFoundationVersion", "__Internal")]
		NSString AMapFoundationVersion { get; }

		// extern NSString *const AMapFoundationName;
		[Field("AMapFoundationName", "__Internal")]
		NSString AMapFoundationName { get; }

		// extern NSString *const MAMapKitVersion;
		[Field("MAMapKitVersion", "__Internal")]
		NSString MAMapKitVersion { get; }

		// extern NSString *const MAMapKitName;
		[Field("MAMapKitName", "__Internal")]
		NSString MAMapKitName { get; }
	//}

	//[Static]
	////[Verify(ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
		// extern const MAMapSize MAMapSizeWorld;
		[Field("MAMapSizeWorld", "__Internal")]
		IntPtr MAMapSizeWorld { get; }

		// extern const MAMapRect MAMapRectWorld;
		[Field("MAMapRectWorld", "__Internal")]
		IntPtr MAMapRectWorld { get; }

		// extern const MAMapRect MAMapRectNull;
		[Field("MAMapRectNull", "__Internal")]
		IntPtr MAMapRectNull { get; }

		// extern const MAMapRect MAMapRectZero;
		[Field("MAMapRectZero", "__Internal")]
		IntPtr MAMapRectZero { get; }


		// extern NSString *const kMAMapLayerCenterMapPointKey;
		[Field("kMAMapLayerCenterMapPointKey", "__Internal")]
		NSString kMAMapLayerCenterMapPointKey { get; }

		// extern NSString *const kMAMapLayerZoomLevelKey;
		[Field("kMAMapLayerZoomLevelKey", "__Internal")]
		NSString kMAMapLayerZoomLevelKey { get; }

		// extern NSString *const kMAMapLayerRotationDegreeKey;
		[Field("kMAMapLayerRotationDegreeKey", "__Internal")]
		NSString kMAMapLayerRotationDegreeKey { get; }

		// extern NSString *const kMAMapLayerCameraDegreeKey;
		[Field("kMAMapLayerCameraDegreeKey", "__Internal")]
		NSString kMAMapLayerCameraDegreeKey { get; }

		[Field("MAOfflineMapErrorDomain", "__Internal")]
		NSString MAOfflineMapErrorDomain { get; }
		// extern NSString *const MAOfflineMapDownloadReceivedSizeKey;
		[Field("MAOfflineMapDownloadReceivedSizeKey", "__Internal")]
		NSString MAOfflineMapDownloadReceivedSizeKey { get; }

		// extern NSString *const MAOfflineMapDownloadExpectedSizeKey;
		[Field("MAOfflineMapDownloadExpectedSizeKey", "__Internal")]
		NSString MAOfflineMapDownloadExpectedSizeKey { get; }
	}

	// typedef void (^AMapTileProjectionBlock)(int, int, int, int, int, int);
	delegate void AMapTileProjectionBlock(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

	// @interface NSValueMAGeometryExtensions (NSValue)
	//[Category]
	[Protocol]
	[BaseType(typeof(NSValue))]
	interface NSValue_NSValueMAGeometryExtensions
	{
		// +(NSValue *)valueWithMAMapPoint:(MAMapPoint)mapPoint;
		[Static]
		[Export("valueWithMAMapPoint:")]
		NSValue ValueWithMAMapPoint(MAMapPoint mapPoint);

		// +(NSValue *)valueWithMAMapSize:(MAMapSize)mapSize;
		[Static]
		[Export("valueWithMAMapSize:")]
		NSValue ValueWithMAMapSize(MAMapSize mapSize);

		// +(NSValue *)valueWithMAMapRect:(MAMapRect)mapRect;
		[Static]
		[Export("valueWithMAMapRect:")]
		NSValue ValueWithMAMapRect(MAMapRect mapRect);

		// +(NSValue *)valueWithMACoordinate:(CLLocationCoordinate2D)coordinate;
		[Static]
		[Export("valueWithMACoordinate:")]
		NSValue ValueWithMACoordinate(CLLocationCoordinate2D coordinate);

		// -(MAMapPoint)MAMapPointValue;
		[Export("MAMapPointValue")]
		//[Verify(MethodToProperty)]
		MAMapPoint MAMapPointValue { get; }

		// -(MAMapSize)MAMapSizeValue;
		[Export("MAMapSizeValue")]
		//[Verify(MethodToProperty)]
		MAMapSize MAMapSizeValue { get; }

		// -(MAMapRect)MAMapRectValue;
		[Export("MAMapRectValue")]
		//[Verify(MethodToProperty)]
		MAMapRect MAMapRectValue { get; }

		// -(CLLocationCoordinate2D)MACoordinateValue;
		[Export("MACoordinateValue")]
		//[Verify(MethodToProperty)]
		CLLocationCoordinate2D MACoordinateValue { get; }
	}

	// @protocol MAAnnotation <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MAAnnotation
	{
		// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
		//[Abstract]
		[Export("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }

		// @optional @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @optional @property (copy, nonatomic) NSString * subtitle;
		[Export("subtitle")]
		string Subtitle { get; set; }

		// @optional -(void)setCoordinate:(CLLocationCoordinate2D)newCoordinate;
		[Export("setCoordinate:")]
		void SetCoordinate(CLLocationCoordinate2D newCoordinate);
	}

	// @protocol MAAnimatableAnnotation <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MAAnimatableAnnotation
	{
		// @required -(void)step:(CGFloat)timeDelta;
		[Abstract]
		[Export("step:")]
		void Step(nfloat timeDelta);

		// @required -(BOOL)isAnimationFinished;
		[Abstract]
		[Export("isAnimationFinished")]
		//[Verify(MethodToProperty)]
		bool IsAnimationFinished { get; }

		// @optional -(CLLocationDirection)rotateDegree;
		[Export("rotateDegree")]
		//[Verify(MethodToProperty)]
		double RotateDegree { get; }
	}

	// @protocol MAOverlay <MAAnnotation>

	[Protocol, Model]
	[BaseType(typeof(MAAnnotation))]
	interface MAOverlay 
	{
		// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
		[Abstract]
		[Export("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }

		// @required @property (readonly, nonatomic) MAMapRect boundingMapRect;
		[Abstract]
		[Export("boundingMapRect")]
		MAMapRect BoundingMapRect { get; }
	}

	//public interface IMAAnnotation { }

	// @interface MAOverlayRenderer : NSObject
	[BaseType(typeof(NSObject))]
	interface MAOverlayRenderer
	{
		// @property (readonly, retain, nonatomic) id<MAOverlay> overlay;
		[Export("overlay", ArgumentSemantic.Retain)]
		MAOverlay Overlay { get; }

		// @property (nonatomic) CGPoint * glPoints;
		[Export("glPoints", ArgumentSemantic.Assign)]
		unsafe CGPoint GlPoints { get; set; }

		// @property (nonatomic) NSUInteger glPointCount;
		[Export("glPointCount")]
		nuint GlPointCount { get; set; }

		// @property (readonly, nonatomic) GLuint strokeTextureID;
		[Export("strokeTextureID")]
		uint StrokeTextureID { get; }

		// -(instancetype)initWithOverlay:(id<MAOverlay>)overlay;
		[Export("initWithOverlay:")]
		IntPtr Constructor(MAOverlay overlay);

		// -(CGPoint)pointForMapPoint:(MAMapPoint)mapPoint;
		[Export("pointForMapPoint:")]
		CGPoint PointForMapPoint(MAMapPoint mapPoint);

		// -(MAMapPoint)mapPointForPoint:(CGPoint)point;
		[Export("mapPointForPoint:")]
		MAMapPoint MapPointForPoint(CGPoint point);

		// -(CGRect)rectForMapRect:(MAMapRect)mapRect;
		[Export("rectForMapRect:")]
		CGRect RectForMapRect(MAMapRect mapRect);

		// -(MAMapRect)mapRectForRect:(CGRect)rect;
		[Export("mapRectForRect:")]
		MAMapRect MapRectForRect(CGRect rect);

		// -(CGPoint)glPointForMapPoint:(MAMapPoint)mapPoint;
		[Export("glPointForMapPoint:")]
		CGPoint GlPointForMapPoint(MAMapPoint mapPoint);

		// -(CGPoint *)glPointsForMapPoints:(MAMapPoint *)mapPoints count:(NSUInteger)count;
		[Export("glPointsForMapPoints:count:")]
		unsafe CGPoint GlPointsForMapPoints(MAMapPoint mapPoints, nuint count);

		// -(CGFloat)glWidthForWindowWidth:(CGFloat)windowWidth;
		[Export("glWidthForWindowWidth:")]
		nfloat GlWidthForWindowWidth(nfloat windowWidth);

		// -(void)referenceDidChange;
		[Export("referenceDidChange")]
		void ReferenceDidChange();

		// -(void)renderLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount strokeColor:(UIColor *)strokeColor lineWidth:(CGFloat)lineWidth looped:(BOOL)looped;
		[Export("renderLinesWithPoints:pointCount:strokeColor:lineWidth:looped:")]
		unsafe void RenderLinesWithPoints(CGPoint points, nuint pointCount, UIColor strokeColor, nfloat lineWidth, bool looped);

		// -(void)renderLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount strokeColor:(UIColor *)strokeColor lineWidth:(CGFloat)lineWidth looped:(BOOL)looped LineJoinType:(MALineJoinType)lineJoinType LineCapType:(MALineCapType)lineCapType lineDash:(BOOL)lineDash;
		[Export("renderLinesWithPoints:pointCount:strokeColor:lineWidth:looped:LineJoinType:LineCapType:lineDash:")]
		unsafe void RenderLinesWithPoints(CGPoint points, nuint pointCount, UIColor strokeColor, nfloat lineWidth, bool looped, MALineJoinType lineJoinType, MALineCapType lineCapType, bool lineDash);

		// -(void)renderTexturedLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount lineWidth:(CGFloat)lineWidth textureID:(GLuint)textureID looped:(BOOL)looped;
		[Export("renderTexturedLinesWithPoints:pointCount:lineWidth:textureID:looped:")]
		unsafe void RenderTexturedLinesWithPoints(CGPoint points, nuint pointCount, nfloat lineWidth, uint textureID, bool looped);

		// -(void)renderTexturedLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount lineWidth:(CGFloat)lineWidth textureIDs:(NSArray *)textureIDs drawStyleIndexes:(NSArray *)drawStyleIndexes looped:(BOOL)looped;
		[Export("renderTexturedLinesWithPoints:pointCount:lineWidth:textureIDs:drawStyleIndexes:looped:")]
		//[Verify(StronglyTypedNSArray), Verify(StronglyTypedNSArray)]
		unsafe void RenderTexturedLinesWithPoints(CGPoint points, nuint pointCount, nfloat lineWidth, NSObject[] textureIDs, NSObject[] drawStyleIndexes, bool looped);

		// -(void)renderLinesWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount strokeColors:(NSArray *)strokeColors drawStyleIndexes:(NSArray *)drawStyleIndexes isGradient:(BOOL)isGradient lineWidth:(CGFloat)lineWidth looped:(BOOL)looped LineJoinType:(MALineJoinType)lineJoinType LineCapType:(MALineCapType)lineCapType lineDash:(BOOL)lineDash;
		[Export("renderLinesWithPoints:pointCount:strokeColors:drawStyleIndexes:isGradient:lineWidth:looped:LineJoinType:LineCapType:lineDash:")]
		//[Verify(StronglyTypedNSArray), Verify(StronglyTypedNSArray)]
		unsafe void RenderLinesWithPoints(CGPoint points, nuint pointCount, NSObject[] strokeColors, NSObject[] drawStyleIndexes, bool isGradient, nfloat lineWidth, bool looped, MALineJoinType lineJoinType, MALineCapType lineCapType, bool lineDash);

		// -(void)renderRegionWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount fillColor:(UIColor *)fillColor usingTriangleFan:(BOOL)usingTriangleFan;
		[Export("renderRegionWithPoints:pointCount:fillColor:usingTriangleFan:")]
		unsafe void RenderRegionWithPoints(CGPoint points, nuint pointCount, UIColor fillColor, bool usingTriangleFan);

		// -(void)renderStrokedRegionWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount fillColor:(UIColor *)fillColor strokeColor:(UIColor *)strokeColor strokeLineWidth:(CGFloat)strokeLineWidth strokeLineJoinType:(MALineJoinType)strokeLineJoinType strokeLineDash:(BOOL)strokeLineDash usingTriangleFan:(BOOL)usingTriangleFan;
		[Export("renderStrokedRegionWithPoints:pointCount:fillColor:strokeColor:strokeLineWidth:strokeLineJoinType:strokeLineDash:usingTriangleFan:")]
		unsafe void RenderStrokedRegionWithPoints(CGPoint points, nuint pointCount, UIColor fillColor, UIColor strokeColor, nfloat strokeLineWidth, MALineJoinType strokeLineJoinType, bool strokeLineDash, bool usingTriangleFan);

		// -(void)renderTextureStrokedRegionWithPoints:(CGPoint *)points pointCount:(NSUInteger)pointCount fillColor:(UIColor *)fillColor strokeTineWidth:(CGFloat)strokeLineWidth strokeTextureID:(GLuint)strokeTexture usingTriangleFan:(BOOL)usingTriangleFan;
		[Export("renderTextureStrokedRegionWithPoints:pointCount:fillColor:strokeTineWidth:strokeTextureID:usingTriangleFan:")]
		unsafe void RenderTextureStrokedRegionWithPoints(CGPoint points, nuint pointCount, UIColor fillColor, nfloat strokeLineWidth, uint strokeTexture, bool usingTriangleFan);

		// -(void)renderIconWithTextureID:(GLuint)textureID points:(CGPoint *)points;
		[Export("renderIconWithTextureID:points:")]
		unsafe void RenderIconWithTextureID(uint textureID, CGPoint points);

		// -(void)renderIconWithTextureID:(GLuint)textureID points:(CGPoint *)points modulateColor:(UIColor *)modulateColor;
		[Export("renderIconWithTextureID:points:modulateColor:")]
		unsafe void RenderIconWithTextureID(uint textureID, CGPoint points, UIColor modulateColor);

		// -(void)glRender;
		[Export("glRender")]
		void GlRender();

		// -(GLuint)loadStrokeTextureImage:(UIImage *)textureImage;
		[Export("loadStrokeTextureImage:")]
		uint LoadStrokeTextureImage(UIImage textureImage);
	}

	// @interface MAAnnotationView : UIView
	[BaseType(typeof(UIView))]
	interface MAAnnotationView
	{
		// @property (readonly, copy, nonatomic) NSString * reuseIdentifier;
		[Export("reuseIdentifier")]
		string ReuseIdentifier { get; }

		// @property (assign, nonatomic) NSInteger zIndex;
		[Export("zIndex")]
		nint ZIndex { get; set; }

		// @property (nonatomic, strong) id<MAAnnotation> annotation;
		[Export("annotation", ArgumentSemantic.Strong)]
		MAAnnotation Annotation { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic) CGPoint centerOffset;
		[Export("centerOffset", ArgumentSemantic.Assign)]
		CGPoint CenterOffset { get; set; }

		// @property (nonatomic) CGPoint calloutOffset;
		[Export("calloutOffset", ArgumentSemantic.Assign)]
		CGPoint CalloutOffset { get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export("enabled")]
		bool Enabled { [Bind("isEnabled")] get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export("highlighted")]
		bool Highlighted { [Bind("isHighlighted")] get; set; }

		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export("selected")]
		bool Selected { [Bind("isSelected")] get; set; }

		// @property (nonatomic) BOOL canShowCallout;
		[Export("canShowCallout")]
		bool CanShowCallout { get; set; }

		// @property (nonatomic, strong) UIView * leftCalloutAccessoryView;
		[Export("leftCalloutAccessoryView", ArgumentSemantic.Strong)]
		UIView LeftCalloutAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * rightCalloutAccessoryView;
		[Export("rightCalloutAccessoryView", ArgumentSemantic.Strong)]
		UIView RightCalloutAccessoryView { get; set; }

		// @property (getter = isDraggable, nonatomic) BOOL draggable;
		[Export("draggable")]
		bool Draggable { [Bind("isDraggable")] get; set; }

		// @property (nonatomic) MAAnnotationViewDragState dragState;
		[Export("dragState", ArgumentSemantic.Assign)]
		MAAnnotationViewDragState DragState { get; set; }

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export("setSelected:animated:")]
		void SetSelected(bool selected, bool animated);

		// -(id)initWithAnnotation:(id<MAAnnotation>)annotation reuseIdentifier:(NSString *)reuseIdentifier;
		[Export("initWithAnnotation:reuseIdentifier:")]
		IntPtr Constructor(MAAnnotation annotation, string reuseIdentifier);

		// -(void)prepareForReuse;
		[Export("prepareForReuse")]
		void PrepareForReuse();

		// -(void)setDragState:(MAAnnotationViewDragState)newDragState animated:(BOOL)animated;
		[Export("setDragState:animated:")]
		void SetDragState(MAAnnotationViewDragState newDragState, bool animated);
	}

	// @interface MAShape : NSObject <MAAnnotation>
	[BaseType(typeof(NSObject))]
	interface MAShape 
	{
		// @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * subtitle;
		[Export("subtitle")]
		string Subtitle { get; set; }
	}

	// @interface MACircle : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	public partial interface MACircle 
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) CLLocationDistance radius;
		[Export("radius")]
		double Radius { get; set; }

		// @property (readonly, nonatomic) MAMapRect boundingMapRect;
		[Export("boundingMapRect")]
		MAMapRect BoundingMapRect { get; }

		// +(instancetype)circleWithCenterCoordinate:(CLLocationCoordinate2D)coord radius:(CLLocationDistance)radius;
		[Static]
		[Export("circleWithCenterCoordinate:radius:")]
		MACircle CircleWithCenterCoordinate(CLLocationCoordinate2D coord, double radius);

		// +(instancetype)circleWithMapRect:(MAMapRect)mapRect;
		[Static]
		[Export("circleWithMapRect:")]
		MACircle CircleWithMapRect(MAMapRect mapRect);
	}

	//public interface IMAOverlay { }

	// @interface MAUserLocation : NSObject <MAAnnotation>
	[BaseType(typeof(NSObject))]
	public partial interface MAUserLocation 
	{
		// @property (readonly, getter = isUpdating, nonatomic) BOOL updating;
		[Export("updating")]
		bool Updating { [Bind("isUpdating")] get; }

		// @property (readonly, nonatomic, strong) CLLocation * location;
		[Export("location", ArgumentSemantic.Strong)]
		CLLocation Location { get; }

		// @property (readonly, nonatomic, strong) CLHeading * heading;
		[Export("heading", ArgumentSemantic.Strong)]
		CLHeading Heading { get; }

		// @property (copy, nonatomic) NSString * title;
		[Export("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * subtitle;
		[Export("subtitle")]
		string Subtitle { get; set; }
	}

	// @interface MAMapStatus : NSObject
	[BaseType(typeof(NSObject))]
	interface MAMapStatus
	{
		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export("centerCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		// @property (nonatomic) CGFloat zoomLevel;
		[Export("zoomLevel")]
		nfloat ZoomLevel { get; set; }

		// @property (nonatomic) CGFloat rotationDegree;
		[Export("rotationDegree")]
		nfloat RotationDegree { get; set; }

		// @property (nonatomic) CGFloat cameraDegree;
		[Export("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (nonatomic) CGPoint screenAnchor;
		[Export("screenAnchor", ArgumentSemantic.Assign)]
		CGPoint ScreenAnchor { get; set; }

		// +(instancetype)statusWithCenterCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel rotationDegree:(CGFloat)rotationDegree cameraDegree:(CGFloat)cameraDegree screenAnchor:(CGPoint)screenAnchor;
		[Static]
		[Export("statusWithCenterCoordinate:zoomLevel:rotationDegree:cameraDegree:screenAnchor:")]
		MAMapStatus StatusWithCenterCoordinate(CLLocationCoordinate2D coordinate, nfloat zoomLevel, nfloat rotationDegree, nfloat cameraDegree, CGPoint screenAnchor);

		// -(id)initWithCenterCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel rotationDegree:(CGFloat)rotationDegree cameraDegree:(CGFloat)cameraDegree screenAnchor:(CGPoint)screenAnchor;
		[Export("initWithCenterCoordinate:zoomLevel:rotationDegree:cameraDegree:screenAnchor:")]
		IntPtr Constructor(CLLocationCoordinate2D coordinate, nfloat zoomLevel, nfloat rotationDegree, nfloat cameraDegree, CGPoint screenAnchor);
	}

	// @interface MAIndoorFloorInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface MAIndoorFloorInfo
	{
		// @property (readonly, nonatomic) NSString * floorName;
		[Export("floorName")]
		string FloorName { get; }

		// @property (readonly, nonatomic) int floorIndex;
		[Export("floorIndex")]
		int FloorIndex { get; }

		// @property (readonly, nonatomic) NSString * floorNona;
		[Export("floorNona")]
		string FloorNona { get; }

		// @property (readonly, nonatomic) BOOL isPark;
		[Export("isPark")]
		bool IsPark { get; }
	}

	// @interface MAIndoorInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface MAIndoorInfo
	{
		// @property (readonly, nonatomic) NSString * cnName;
		[Export("cnName")]
		string CnName { get; }

		// @property (readonly, nonatomic) NSString * enName;
		[Export("enName")]
		string EnName { get; }

		// @property (readonly, nonatomic) NSString * poiID;
		[Export("poiID")]
		string PoiID { get; }

		// @property (readonly, nonatomic) NSString * buildingType;
		[Export("buildingType")]
		string BuildingType { get; }

		// @property (readonly, nonatomic) int activeFloorIndex;
		[Export("activeFloorIndex")]
		int ActiveFloorIndex { get; }

		// @property (readonly, nonatomic) int activeFloorInfoIndex;
		[Export("activeFloorInfoIndex")]
		int ActiveFloorInfoIndex { get; }

		// @property (readonly, nonatomic) NSArray * floorInfo;
		[Export("floorInfo")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] FloorInfo { get; }

		// @property (readonly, nonatomic) int numberOfFloor;
		[Export("numberOfFloor")]
		int NumberOfFloor { get; }

		// @property (readonly, nonatomic) int numberOfParkFloor;
		[Export("numberOfParkFloor")]
		int NumberOfParkFloor { get; }
	}

	// @interface MAUserLocationRepresentation : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MAUserLocationRepresentation
	{
		// @property (assign, nonatomic) BOOL showsAccuracyRing;
		[Export("showsAccuracyRing")]
		bool ShowsAccuracyRing { get; set; }

		// @property (assign, nonatomic) BOOL showsHeadingIndicator;
		[Export("showsHeadingIndicator")]
		bool ShowsHeadingIndicator { get; set; }

		// @property (nonatomic, strong) UIColor * fillColor;
		[Export("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (nonatomic, strong) UIColor * strokeColor;
		[Export("strokeColor", ArgumentSemantic.Strong)]
		UIColor StrokeColor { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (nonatomic, strong) UIColor * locationDotBgColor;
		[Export("locationDotBgColor", ArgumentSemantic.Strong)]
		UIColor LocationDotBgColor { get; set; }

		// @property (nonatomic, strong) UIColor * locationDotFillColor;
		[Export("locationDotFillColor", ArgumentSemantic.Strong)]
		UIColor LocationDotFillColor { get; set; }

		// @property (assign, nonatomic) BOOL enablePulseAnnimation;
		[Export("enablePulseAnnimation")]
		bool EnablePulseAnnimation { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }
	}

	//[Static]
	////[Verify(ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//}

	// @interface MAMapView : UIView
	[BaseType(typeof(UIView))]
	interface MAMapView
	{
		[Wrap("WeakDelegate")]
		MAMapViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MAMapViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) MAMapType mapType;
		[Export("mapType", ArgumentSemantic.Assign)]
		MAMapType MapType { get; set; }

		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export("centerCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		// @property (nonatomic) MACoordinateRegion region;
		[Export("region", ArgumentSemantic.Assign)]
		MACoordinateRegion Region { get; set; }

		// @property (nonatomic) MAMapRect visibleMapRect;
		[Export("visibleMapRect", ArgumentSemantic.Assign)]
		MAMapRect VisibleMapRect { get; set; }

		// @property (assign, nonatomic) MACoordinateRegion limitRegion;
		[Export("limitRegion", ArgumentSemantic.Assign)]
		MACoordinateRegion LimitRegion { get; set; }

		// @property (assign, nonatomic) MAMapRect limitMapRect;
		[Export("limitMapRect", ArgumentSemantic.Assign)]
		MAMapRect LimitMapRect { get; set; }

		// @property (nonatomic) CGFloat zoomLevel;
		[Export("zoomLevel")]
		nfloat ZoomLevel { get; set; }

		// @property (nonatomic) CGFloat minZoomLevel;
		[Export("minZoomLevel")]
		nfloat MinZoomLevel { get; set; }

		// @property (nonatomic) CGFloat maxZoomLevel;
		[Export("maxZoomLevel")]
		nfloat MaxZoomLevel { get; set; }

		// @property (nonatomic) CGFloat rotationDegree;
		[Export("rotationDegree")]
		nfloat RotationDegree { get; set; }

		// @property (nonatomic) CGFloat cameraDegree;
		[Export("cameraDegree")]
		nfloat CameraDegree { get; set; }

		// @property (assign, nonatomic) BOOL zoomingInPivotsAroundAnchorPoint;
		[Export("zoomingInPivotsAroundAnchorPoint")]
		bool ZoomingInPivotsAroundAnchorPoint { get; set; }

		// @property (getter = isZoomEnabled, nonatomic) BOOL zoomEnabled;
		[Export("zoomEnabled")]
		bool ZoomEnabled { [Bind("isZoomEnabled")] get; set; }

		// @property (getter = isScrollEnabled, nonatomic) BOOL scrollEnabled;
		[Export("scrollEnabled")]
		bool ScrollEnabled { [Bind("isScrollEnabled")] get; set; }

		// @property (getter = isRotateEnabled, nonatomic) BOOL rotateEnabled;
		[Export("rotateEnabled")]
		bool RotateEnabled { [Bind("isRotateEnabled")] get; set; }

		// @property (getter = isRotateCameraEnabled, nonatomic) BOOL rotateCameraEnabled;
		[Export("rotateCameraEnabled")]
		bool RotateCameraEnabled { [Bind("isRotateCameraEnabled")] get; set; }

		// @property (getter = isSkyModelEnabled, nonatomic) BOOL skyModelEnable;
		[Export("skyModelEnable")]
		bool SkyModelEnable { [Bind("isSkyModelEnabled")] get; set; }

		// @property (getter = isShowsBuildings, nonatomic) BOOL showsBuildings;
		[Export("showsBuildings")]
		bool ShowsBuildings { [Bind("isShowsBuildings")] get; set; }

		// @property (getter = isShowsLabels, assign, nonatomic) BOOL showsLabels;
		[Export("showsLabels")]
		bool ShowsLabels { [Bind("isShowsLabels")] get; set; }

		// @property (getter = isShowTraffic, nonatomic) BOOL showTraffic;
		[Export("showTraffic")]
		bool ShowTraffic { [Bind("isShowTraffic")] get; set; }

		// @property (copy, nonatomic) NSDictionary<NSNumber *,UIColor *> * trafficStatus;
		[Export("trafficStatus", ArgumentSemantic.Copy)]
		NSDictionary<NSNumber, UIColor> TrafficStatus { get; set; }

		// @property (assign, nonatomic) BOOL touchPOIEnabled;
		[Export("touchPOIEnabled")]
		bool TouchPOIEnabled { get; set; }

		// @property (assign, nonatomic) BOOL showsCompass;
		[Export("showsCompass")]
		bool ShowsCompass { get; set; }

		// @property (assign, nonatomic) CGPoint compassOrigin;
		[Export("compassOrigin", ArgumentSemantic.Assign)]
		CGPoint CompassOrigin { get; set; }

		// @property (readonly, nonatomic) CGSize compassSize;
		[Export("compassSize")]
		CGSize CompassSize { get; }

		// @property (assign, nonatomic) BOOL showsScale;
		[Export("showsScale")]
		bool ShowsScale { get; set; }

		// @property (assign, nonatomic) CGPoint scaleOrigin;
		[Export("scaleOrigin", ArgumentSemantic.Assign)]
		CGPoint ScaleOrigin { get; set; }

		// @property (readonly, nonatomic) CGSize scaleSize;
		[Export("scaleSize")]
		CGSize ScaleSize { get; }

		// @property (assign, nonatomic) CGPoint logoCenter;
		[Export("logoCenter", ArgumentSemantic.Assign)]
		CGPoint LogoCenter { get; set; }

		// @property (readonly, nonatomic) CGSize logoSize;
		[Export("logoSize")]
		CGSize LogoSize { get; }

		// @property (readonly, nonatomic) double metersPerPointForCurrentZoom;
		[Export("metersPerPointForCurrentZoom")]
		double MetersPerPointForCurrentZoom { get; }

		// @property (readonly, nonatomic) BOOL isAbroad;
		[Export("isAbroad")]
		bool IsAbroad { get; }

		// @property (assign, nonatomic) NSUInteger maxRenderFrame;
		[Export("maxRenderFrame")]
		nuint MaxRenderFrame { get; set; }

		// @property (assign, nonatomic) BOOL isAllowDecreaseFrame;
		[Export("isAllowDecreaseFrame")]
		bool IsAllowDecreaseFrame { get; set; }

		// @property (assign, nonatomic) BOOL openGLESDisabled;
		[Export("openGLESDisabled")]
		bool OpenGLESDisabled { get; set; }

		// -(void)setRegion:(MACoordinateRegion)region animated:(BOOL)animated;
		[Export("setRegion:animated:")]
		void SetRegion(MACoordinateRegion region, bool animated);

		// -(MACoordinateRegion)regionThatFits:(MACoordinateRegion)region;
		[Export("regionThatFits:")]
		MACoordinateRegion RegionThatFits(MACoordinateRegion region);

		// -(void)setVisibleMapRect:(MAMapRect)mapRect animated:(BOOL)animated;
		[Export("setVisibleMapRect:animated:")]
		void SetVisibleMapRect(MAMapRect mapRect, bool animated);

		// -(MAMapRect)mapRectThatFits:(MAMapRect)mapRect;
		[Export("mapRectThatFits:")]
		MAMapRect MapRectThatFits(MAMapRect mapRect);

		// -(MAMapRect)mapRectThatFits:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets;
		[Export("mapRectThatFits:edgePadding:")]
		MAMapRect MapRectThatFits(MAMapRect mapRect, UIEdgeInsets insets);

		// -(void)setVisibleMapRect:(MAMapRect)mapRect edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("setVisibleMapRect:edgePadding:animated:")]
		void SetVisibleMapRect(MAMapRect mapRect, UIEdgeInsets insets, bool animated);

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
		[Export("setCenterCoordinate:animated:")]
		void SetCenterCoordinate(CLLocationCoordinate2D coordinate, bool animated);

		// -(void)setZoomLevel:(CGFloat)zoomLevel animated:(BOOL)animated;
		[Export("setZoomLevel:animated:")]
		void SetZoomLevel(nfloat zoomLevel, bool animated);

		// -(void)setZoomLevel:(CGFloat)zoomLevel atPivot:(CGPoint)pivot animated:(BOOL)animated;
		[Export("setZoomLevel:atPivot:animated:")]
		void SetZoomLevel(nfloat zoomLevel, CGPoint pivot, bool animated);

		// -(void)setRotationDegree:(CGFloat)rotationDegree animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export("setRotationDegree:animated:duration:")]
		void SetRotationDegree(nfloat rotationDegree, bool animated, double duration);

		// -(void)setCameraDegree:(CGFloat)cameraDegree animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export("setCameraDegree:animated:duration:")]
		void SetCameraDegree(nfloat cameraDegree, bool animated, double duration);

		// -(MAMapStatus *)getMapStatus;
		[Export("getMapStatus")]
		//[Verify(MethodToProperty)]
		MAMapStatus MapStatus { get; }

		// -(void)setMapStatus:(MAMapStatus *)status animated:(BOOL)animated;
		[Export("setMapStatus:animated:")]
		void SetMapStatus(MAMapStatus status, bool animated);

		// -(void)setMapStatus:(MAMapStatus *)status animated:(BOOL)animated duration:(CFTimeInterval)duration;
		[Export("setMapStatus:animated:duration:")]
		void SetMapStatus(MAMapStatus status, bool animated, double duration);

		// -(void)setCustomMapStyle:(NSData *)customJson;
		[Export("setCustomMapStyle:")]
		void SetCustomMapStyle(NSData customJson);

		// -(void)setCompassImage:(UIImage *)image;
		[Export("setCompassImage:")]
		void SetCompassImage(UIImage image);

		// -(UIImage *)takeSnapshotInRect:(CGRect)rect;
		[Export("takeSnapshotInRect:")]
		UIImage TakeSnapshotInRect(CGRect rect);

		// -(void)takeSnapshotInRect:(CGRect)rect withCompletionBlock:(void (^)(UIImage *, NSInteger))block;
		[Export("takeSnapshotInRect:withCompletionBlock:")]
		void TakeSnapshotInRect(CGRect rect, Action<UIImage, nint> block);

		// -(double)metersPerPointForZoomLevel:(CGFloat)zoomLevel;
		[Export("metersPerPointForZoomLevel:")]
		double MetersPerPointForZoomLevel(nfloat zoomLevel);

		// -(CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView *)view;
		[Export("convertCoordinate:toPointToView:")]
		CGPoint ConvertCoordinate(CLLocationCoordinate2D coordinate, UIView view);

		// -(CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView *)view;
		[Export("convertPoint:toCoordinateFromView:")]
		CLLocationCoordinate2D ConvertPoint(CGPoint point, UIView view);

		// -(CGRect)convertRegion:(MACoordinateRegion)region toRectToView:(UIView *)view;
		[Export("convertRegion:toRectToView:")]
		CGRect ConvertRegion(MACoordinateRegion region, UIView view);

		// -(MACoordinateRegion)convertRect:(CGRect)rect toRegionFromView:(UIView *)view;
		[Export("convertRect:toRegionFromView:")]
		MACoordinateRegion ConvertRect(CGRect rect, UIView view);

		// -(void)reloadMap;
		[Export("reloadMap")]
		void ReloadMap();

		// -(void)clearDisk;
		[Export("clearDisk")]
		void ClearDisk();
	}

	// @interface Annotation (MAMapView)
	//[Category]
	[Protocol]
	[BaseType(typeof(MAMapView))]
	interface MAMapView_Annotation
	{
		// @property (readonly, nonatomic) NSArray * annotations;
		[Export("annotations")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Annotations { get; }

		// @property (copy, nonatomic) NSArray * selectedAnnotations;
		[Export("selectedAnnotations", ArgumentSemantic.Copy)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] SelectedAnnotations { get; set; }

		// @property (readonly, nonatomic) CGRect annotationVisibleRect;
		[Export("annotationVisibleRect")]
		CGRect AnnotationVisibleRect { get; }

		// @property (assign, nonatomic) BOOL allowsAnnotationViewSorting;
		[Export("allowsAnnotationViewSorting")]
		bool AllowsAnnotationViewSorting { get; set; }

		// -(void)addAnnotation:(id<MAAnnotation>)annotation;
		[Export("addAnnotation:")]
		void AddAnnotation(MAAnnotation annotation);

		// -(void)addAnnotations:(NSArray *)annotations;
		[Export("addAnnotations:")]
		//[Verify(StronglyTypedNSArray)]
		void AddAnnotations(NSObject[] annotations);

		// -(void)removeAnnotation:(id<MAAnnotation>)annotation;
		[Export("removeAnnotation:")]
		void RemoveAnnotation(MAAnnotation annotation);

		// -(void)removeAnnotations:(NSArray *)annotations;
		[Export("removeAnnotations:")]
		//[Verify(StronglyTypedNSArray)]
		void RemoveAnnotations(NSObject[] annotations);

		// -(NSSet *)annotationsInMapRect:(MAMapRect)mapRect;
		[Export("annotationsInMapRect:")]
		NSSet AnnotationsInMapRect(MAMapRect mapRect);

		// -(MAAnnotationView *)viewForAnnotation:(id<MAAnnotation>)annotation;
		[Export("viewForAnnotation:")]
		MAAnnotationView ViewForAnnotation(MAAnnotation annotation);

		// -(MAAnnotationView *)dequeueReusableAnnotationViewWithIdentifier:(NSString *)identifier;
		[Export("dequeueReusableAnnotationViewWithIdentifier:")]
		MAAnnotationView DequeueReusableAnnotationViewWithIdentifier(string identifier);

		// -(void)selectAnnotation:(id<MAAnnotation>)annotation animated:(BOOL)animated;
		[Export("selectAnnotation:animated:")]
		void SelectAnnotation(MAAnnotation annotation, bool animated);

		// -(void)deselectAnnotation:(id<MAAnnotation>)annotation animated:(BOOL)animated;
		[Export("deselectAnnotation:animated:")]
		void DeselectAnnotation(MAAnnotation annotation, bool animated);

		// -(void)showAnnotations:(NSArray *)annotations animated:(BOOL)animated;
		[Export("showAnnotations:animated:")]
		//[Verify(StronglyTypedNSArray)]
		void ShowAnnotations(NSObject[] annotations, bool animated);

		// -(void)showAnnotations:(NSArray *)annotations edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("showAnnotations:edgePadding:animated:")]
		//[Verify(StronglyTypedNSArray)]
		void ShowAnnotations(NSObject[] annotations, UIEdgeInsets insets, bool animated);
	}

	// @interface UserLocation (MAMapView)
	//[Category]
	//[Protocol]
	[BaseType(typeof(MAMapView))]
	[Category]
	interface  MAMapView_UserLocation
	{
		// @property (nonatomic) BOOL showsUserLocation;
		[Export("showsUserLocation")]
		//bool ShowsUserLocation { get; set; }
		bool ShowsUserLocation();
		[Export("setShowsUserLocation:")]
		void SetShowsUserLocation(bool showsUserLocation);


		// @property (readonly, nonatomic) MAUserLocation * userLocation;
		[Export("userLocation")]
		//MAUserLocation UserLocation { get; }
		MAUserLocation UserLocation();

		// @property (nonatomic) BOOL customizeUserLocationAccuracyCircleRepresentation;
		[Export("customizeUserLocationAccuracyCircleRepresentation")]
		//bool CustomizeUserLocationAccuracyCircleRepresentation { get; set; }
		bool CustomizeUserLocationAccuracyCircleRepresentation();
		[Export("setCustomizeUserLocationAccuracyCircleRepresentation:")]
		void SetCustomizeUserLocationAccuracyCircleRepresentation(bool customizeUserLocationAccuracyCircleRepresentation);

		// @property (readonly, nonatomic) MACircle * userLocationAccuracyCircle;
		[Export("userLocationAccuracyCircle")]
		//MACircle UserLocationAccuracyCircle { get; }
		MACircle UserLocationAccuracyCircle();
		[Export("setUserLocationAccuracyCircle:")]
		void SetUserLocationAccuracyCircle(MACircle UserLocationAccuracyCircle);
		// @property (nonatomic) MAUserTrackingMode userTrackingMode;
		[Export("userTrackingMode", ArgumentSemantic.Assign)]
		//MAUserTrackingMode UserTrackingMode { get; set; }
		MAUserTrackingMode UserTrackingMode();
		[Export("setUserTrackingMode:")]
		void SetUserTrackingMode(MAUserTrackingMode userTrackingMode);

		// @property (readonly, getter = isUserLocationVisible, nonatomic) BOOL userLocationVisible;
		// 临时隐藏
		//[Export("userLocationVisible")]
		//bool UserLocationVisible { [Bind("isUserLocationVisible")] get; }

		// @property (nonatomic) CLLocationDistance distanceFilter;
		[Export("distanceFilter")]
		//double DistanceFilter { get; set; }
		double DistanceFilter();
		[Export("setDistanceFilter:")]
		void SetDistanceFilter(double distanceFilter);
		// @property (nonatomic) CLLocationAccuracy desiredAccuracy;
		[Export("desiredAccuracy")]
		//double DesiredAccuracy { get; set; }
		double DesiredAccuracy();
		[Export("setDesiredAccuracy:")]
		void setDesiredAccuracy(double desiredAccuracy);
		// @property (nonatomic) CLLocationDegrees headingFilter;
		[Export("headingFilter")]
		//double HeadingFilter { get; set; }
		double HeadingFilter();
		[Export("setHeadingFilter:")]
		//double HeadingFilter { get; set; }
		void HeadingFilter(double headingFilter);
		// @property (nonatomic) BOOL pausesLocationUpdatesAutomatically;
		[Export("pausesLocationUpdatesAutomatically")]
		//bool PausesLocationUpdatesAutomatically { get; set; }
		bool PausesLocationUpdatesAutomatically();
		[Export("setPausesLocationUpdatesAutomatically:")]
		void setPausesLocationUpdatesAutomatically(bool pausesLocationUpdatesAutomatically);
		// @property (nonatomic) BOOL allowsBackgroundLocationUpdates;
		[Export("allowsBackgroundLocationUpdates")]
		//bool AllowsBackgroundLocationUpdates { get; set; }
		bool AllowsBackgroundLocationUpdates();
		[Export("setAllowsBackgroundLocationUpdates:")]
		void SetAllowsBackgroundLocationUpdates(bool allowsBackgroundLocationUpdates);
		//bool AllowsBackgroundLocationUpdates
		// -(void)setUserTrackingMode:(MAUserTrackingMode)mode animated:(BOOL)animated;
		[Export("setUserTrackingMode:animated:")]
		void SetUserTrackingMode(MAUserTrackingMode mode, bool animated);

		// -(void)updateUserLocationRepresentation:(MAUserLocationRepresentation *)representation;
		[Export("updateUserLocationRepresentation:")]
		void UpdateUserLocationRepresentation(MAUserLocationRepresentation representation);
	}

	// @interface Overlay (MAMapView)
	//[Category]
	[Protocol]
	[BaseType(typeof(MAMapView))]
	interface MAMapView_Overlay
	{
		// @property (readonly, nonatomic) NSArray * overlays;
		[Export("overlays")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Overlays { get; }

		// -(NSArray *)overlaysInLevel:(MAOverlayLevel)level;
		[Export("overlaysInLevel:")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] OverlaysInLevel(MAOverlayLevel level);

		// -(void)addOverlay:(id<MAOverlay>)overlay;
		[Export("addOverlay:")]
		void AddOverlay(MAOverlay overlay);

		// -(void)addOverlays:(NSArray *)overlays;
		[Export("addOverlays:")]
		//[Verify(StronglyTypedNSArray)]
		void AddOverlays(NSObject[] overlays);

		// -(void)addOverlay:(id<MAOverlay>)overlay level:(MAOverlayLevel)level;
		[Export("addOverlay:level:")]
		void AddOverlay(MAOverlay overlay, MAOverlayLevel level);

		// -(void)addOverlays:(NSArray *)overlays level:(MAOverlayLevel)level;
		[Export("addOverlays:level:")]
		//[Verify(StronglyTypedNSArray)]
		void AddOverlays(NSObject[] overlays, MAOverlayLevel level);

		// -(void)removeOverlay:(id<MAOverlay>)overlay;
		[Export("removeOverlay:")]
		void RemoveOverlay(MAOverlay overlay);

		// -(void)removeOverlays:(NSArray *)overlays;
		[Export("removeOverlays:")]
		//[Verify(StronglyTypedNSArray)]
		void RemoveOverlays(NSObject[] overlays);

		// -(void)insertOverlay:(id<MAOverlay>)overlay atIndex:(NSUInteger)index level:(MAOverlayLevel)level;
		[Export("insertOverlay:atIndex:level:")]
		void InsertOverlay(MAOverlay overlay, nuint index, MAOverlayLevel level);

		// -(void)insertOverlay:(id<MAOverlay>)overlay aboveOverlay:(id<MAOverlay>)sibling;
		[Export("insertOverlay:aboveOverlay:")]
		void InsertOverlay(MAOverlay overlay, MAOverlay sibling);

		// -(void)insertOverlay:(id<MAOverlay>)overlay belowOverlay:(id<MAOverlay>)sibling;
		[Export("insertOverlay:belowOverlay:")]
		void AInsertOverlay(MAOverlay overlay, MAOverlay sibling);

		// -(void)insertOverlay:(id<MAOverlay>)overlay atIndex:(NSUInteger)index;
		[Export("insertOverlay:atIndex:")]
		void InsertOverlay(MAOverlay overlay, nuint index);

		// -(void)exchangeOverlayAtIndex:(NSUInteger)index1 withOverlayAtIndex:(NSUInteger)index2;
		[Export("exchangeOverlayAtIndex:withOverlayAtIndex:")]
		void ExchangeOverlayAtIndex(nuint index1, nuint index2);

		// -(void)exchangeOverlayAtIndex:(NSUInteger)index1 withOverlayAtIndex:(NSUInteger)index2 atLevel:(MAOverlayLevel)level;
		[Export("exchangeOverlayAtIndex:withOverlayAtIndex:atLevel:")]
		void ExchangeOverlayAtIndex(nuint index1, nuint index2, MAOverlayLevel level);

		// -(void)exchangeOverlay:(id<MAOverlay>)overlay1 withOverlay:(id<MAOverlay>)overlay2;
		[Export("exchangeOverlay:withOverlay:")]
		void ExchangeOverlay(MAOverlay overlay1, MAOverlay overlay2);

		// -(MAOverlayRenderer *)rendererForOverlay:(id<MAOverlay>)overlay;
		[Export("rendererForOverlay:")]
		MAOverlayRenderer RendererForOverlay(MAOverlay overlay);

		// -(void)showOverlays:(NSArray *)overlays animated:(BOOL)animated;
		[Export("showOverlays:animated:")]
		//[Verify(StronglyTypedNSArray)]
		void ShowOverlays(NSObject[] overlays, bool animated);

		// -(void)showOverlays:(NSArray *)overlays edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("showOverlays:edgePadding:animated:")]
		//[Verify(StronglyTypedNSArray)]
		void ShowOverlays(NSObject[] overlays, UIEdgeInsets insets, bool animated);
	}

	// @interface InDoor (MAMapView)
	//[Category]
	[Protocol]
	[BaseType(typeof(MAMapView))]
	interface MAMapView_InDoor
	{
		// @property (getter = isShowsIndoorMap, nonatomic) BOOL showsIndoorMap;
		[Export("showsIndoorMap")]
		bool ShowsIndoorMap { [Bind("isShowsIndoorMap")] get; set; }

		// @property (getter = isShowsIndoorMapControl, nonatomic) BOOL showsIndoorMapControl;
		[Export("showsIndoorMapControl")]
		bool ShowsIndoorMapControl { [Bind("isShowsIndoorMapControl")] get; set; }

		// @property (readonly, nonatomic) CGSize indoorMapControlSize;
		[Export("indoorMapControlSize")]
		CGSize IndoorMapControlSize { get; }

		// -(void)setIndoorMapControlOrigin:(CGPoint)origin;
		[Export("setIndoorMapControlOrigin:")]
		void SetIndoorMapControlOrigin(CGPoint origin);

		// -(void)setCurrentIndoorMapFloorIndex:(NSInteger)floorIndex;
		[Export("setCurrentIndoorMapFloorIndex:")]
		void SetCurrentIndoorMapFloorIndex(nint floorIndex);

		// -(void)clearIndoorMapCache;
		[Export("clearIndoorMapCache")]
		void ClearIndoorMapCache();
	}

	// @protocol MAMapViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MAMapViewDelegate
	{
		// @optional -(void)mapViewRegionChanged:(MAMapView *)mapView;
		[Export("mapViewRegionChanged:")]
		void MapViewRegionChanged(MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView regionWillChangeAnimated:(BOOL)animated;
		[Export("mapView:regionWillChangeAnimated:")]
		void MapView(MAMapView mapView, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView regionDidChangeAnimated:(BOOL)animated;
		[Export("mapView:regionDidChangeAnimated:")]
		void AMapView(MAMapView mapView, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView mapWillMoveByUser:(BOOL)wasUserAction;
		[Export("mapView:mapWillMoveByUser:")]
		void MapViewWillMoveByUser(MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapDidMoveByUser:(BOOL)wasUserAction;
		[Export("mapView:mapDidMoveByUser:")]
		void MapViewDidMoveByUser(MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapWillZoomByUser:(BOOL)wasUserAction;
		[Export("mapView:mapWillZoomByUser:")]
		void MapViewWillZoomByUse(MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapView:(MAMapView *)mapView mapDidZoomByUser:(BOOL)wasUserAction;
		[Export("mapView:mapDidZoomByUser:")]
		void AMapViewDidZoomByUser(MAMapView mapView, bool wasUserAction);

		// @optional -(void)mapViewWillStartLoadingMap:(MAMapView *)mapView;
		[Export("mapViewWillStartLoadingMap:")]
		void MapViewWillStartLoadingMap(MAMapView mapView);

		// @optional -(void)mapViewDidFinishLoadingMap:(MAMapView *)mapView;
		[Export("mapViewDidFinishLoadingMap:")]
		void MapViewDidFinishLoadingMap(MAMapView mapView);

		// @optional -(void)mapViewDidFailLoadingMap:(MAMapView *)mapView withError:(NSError *)error;
		[Export("mapViewDidFailLoadingMap:withError:")]
		void MapViewDidFailLoadingMap(MAMapView mapView, NSError error);

		// @optional -(MAAnnotationView *)mapView:(MAMapView *)mapView viewForAnnotation:(id<MAAnnotation>)annotation;
		[Export("mapView:viewForAnnotation:")]
		MAAnnotationView MapView(MAMapView mapView, MAAnnotation annotation);

		// @optional -(void)mapView:(MAMapView *)mapView didAddAnnotationViews:(NSArray *)views;
		[Export("mapView:didAddAnnotationViews:")]
		//[Verify(StronglyTypedNSArray)]
		void MapView(MAMapView mapView, NSObject[] views);

		// @optional -(void)mapView:(MAMapView *)mapView didSelectAnnotationView:(MAAnnotationView *)view;
		[Export("mapView:didSelectAnnotationView:")]
		void MapViewSelectAnnotationView(MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapView:(MAMapView *)mapView didDeselectAnnotationView:(MAAnnotationView *)view;
		[Export("mapView:didDeselectAnnotationView:")]
		void MapViewDeselectAnnotationView(MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapViewWillStartLocatingUser:(MAMapView *)mapView;
		[Export("mapViewWillStartLocatingUser:")]
		void MapViewWillStartLocatingUser(MAMapView mapView);

		// @optional -(void)mapViewDidStopLocatingUser:(MAMapView *)mapView;
		[Export("mapViewDidStopLocatingUser:")]
		void MapViewDidStopLocatingUser(MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView didUpdateUserLocation:(MAUserLocation *)userLocation updatingLocation:(BOOL)updatingLocation;
		[Export("mapView:didUpdateUserLocation:updatingLocation:")]
		void MapView(MAMapView mapView, MAUserLocation userLocation, bool updatingLocation);

		// @optional -(void)mapView:(MAMapView *)mapView didFailToLocateUserWithError:(NSError *)error;
		[Export("mapView:didFailToLocateUserWithError:")]
		void MapView(MAMapView mapView, NSError error);

		// @optional -(void)mapView:(MAMapView *)mapView annotationView:(MAAnnotationView *)view didChangeDragState:(MAAnnotationViewDragState)newState fromOldState:(MAAnnotationViewDragState)oldState;
		[Export("mapView:annotationView:didChangeDragState:fromOldState:")]
		void MapView(MAMapView mapView, MAAnnotationView view, MAAnnotationViewDragState newState, MAAnnotationViewDragState oldState);

		// @optional -(MAOverlayRenderer *)mapView:(MAMapView *)mapView rendererForOverlay:(id<MAOverlay>)overlay;
		[Export("mapView:rendererForOverlay:")]
		MAOverlayRenderer MapView(MAMapView mapView, MAOverlay overlay);

		// @optional -(void)mapView:(MAMapView *)mapView didAddOverlayRenderers:(NSArray *)overlayRenderers;
		[Export("mapView:didAddOverlayRenderers:")]
		//[Verify(StronglyTypedNSArray)]
		void MapViewAddOverlayRenderers(MAMapView mapView, NSObject[] overlayRenderers);

		// @optional -(void)mapView:(MAMapView *)mapView annotationView:(MAAnnotationView *)view calloutAccessoryControlTapped:(UIControl *)control;
		[Export("mapView:annotationView:calloutAccessoryControlTapped:")]
		void MapView(MAMapView mapView, MAAnnotationView view, UIControl control);

		// @optional -(void)mapView:(MAMapView *)mapView didAnnotationViewCalloutTapped:(MAAnnotationView *)view;
		[Export("mapView:didAnnotationViewCalloutTapped:")]
		void MapView(MAMapView mapView, MAAnnotationView view);

		// @optional -(void)mapView:(MAMapView *)mapView didChangeUserTrackingMode:(MAUserTrackingMode)mode animated:(BOOL)animated;
		[Export("mapView:didChangeUserTrackingMode:animated:")]
		void MapView(MAMapView mapView, MAUserTrackingMode mode, bool animated);

		// @optional -(void)mapView:(MAMapView *)mapView didChangeOpenGLESDisabled:(BOOL)openGLESDisabled;
		[Export("mapView:didChangeOpenGLESDisabled:")]
		void MapViewChangeOpenGLESDisabled(MAMapView mapView, bool openGLESDisabled);

		// @optional -(void)mapView:(MAMapView *)mapView didTouchPois:(NSArray *)pois;
		[Export("mapView:didTouchPois:")]
		//[Verify(StronglyTypedNSArray)]
		void MapViewdidTouchPois(MAMapView mapView, NSObject[] pois);

		// @optional -(void)mapView:(MAMapView *)mapView didSingleTappedAtCoordinate:(CLLocationCoordinate2D)coordinate;
		[Export("mapView:didSingleTappedAtCoordinate:")]
		void MapView(MAMapView mapView, CLLocationCoordinate2D coordinate);

		// @optional -(void)mapView:(MAMapView *)mapView didLongPressedAtCoordinate:(CLLocationCoordinate2D)coordinate;
		[Export("mapView:didLongPressedAtCoordinate:")]
		void MapViewLongPressedAtCoordinate(MAMapView mapView, CLLocationCoordinate2D coordinate);

		// @optional -(void)mapInitComplete:(MAMapView *)mapView;
		[Export("mapInitComplete:")]
		void MapInitComplete(MAMapView mapView);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapShowed:(MAIndoorInfo *)indoorInfo;
		[Export("mapView:didIndoorMapShowed:")]
		void MapViewIndoorMapShowed(MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapFloorIndexChanged:(MAIndoorInfo *)indoorInfo;
		[Export("mapView:didIndoorMapFloorIndexChanged:")]
		void MapViewIndoorMapFloorIndexChanged(MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)mapView:(MAMapView *)mapView didIndoorMapHidden:(MAIndoorInfo *)indoorInfo;
		[Export("mapView:didIndoorMapHidden:")]
		void MapView(MAMapView mapView, MAIndoorInfo indoorInfo);

		// @optional -(void)offlineDataWillReload:(MAMapView *)mapView;
		[Export("offlineDataWillReload:")]
		void OfflineDataWillReload(MAMapView mapView);

		// @optional -(void)offlineDataDidReload:(MAMapView *)mapView;
		[Export("offlineDataDidReload:")]
		void OfflineDataDidReload(MAMapView mapView);
	}

	// @interface MAPointAnnotation : MAShape
	[BaseType(typeof(MAShape))]
	interface MAPointAnnotation
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (getter = isLockedToScreen, assign, nonatomic) BOOL lockedToScreen;
		[Export("lockedToScreen")]
		bool LockedToScreen { [Bind("isLockedToScreen")] get; set; }

		// @property (assign, nonatomic) CGPoint lockedScreenPoint;
		[Export("lockedScreenPoint", ArgumentSemantic.Assign)]
		CGPoint LockedScreenPoint { get; set; }
	}

	// @interface MAAnnotationMoveAnimation : NSObject
	[BaseType(typeof(NSObject))]
	interface MAAnnotationMoveAnimation
	{
		// -(NSString *)name;
		[Export("name")]
		//[Verify(MethodToProperty)]
		string Name { get; }

		// -(CLLocationCoordinate2D *)coordinates;
		[Export("coordinates")]
		//[Verify(MethodToProperty)]
		unsafe CLLocationCoordinate2D Coordinates { get; }

		// -(NSUInteger)count;
		[Export("count")]
		//[Verify(MethodToProperty)]
		nuint Count { get; }

		// -(CGFloat)duration;
		[Export("duration")]
		//[Verify(MethodToProperty)]
		nfloat Duration { get; }

		// -(CGFloat)elapsedTime;
		[Export("elapsedTime")]
		//[Verify(MethodToProperty)]
		nfloat ElapsedTime { get; }

		// -(void)cancel;
		[Export("cancel")]
		void Cancel();

		// -(BOOL)isCancelled;
		[Export("isCancelled")]
		//[Verify(MethodToProperty)]
		bool IsCancelled { get; }
	}

	// @interface MAAnimatedAnnotation : MAPointAnnotation <MAAnimatableAnnotation>
	[BaseType(typeof(MAPointAnnotation))]
	interface MAAnimatedAnnotation : IMAAnimatableAnnotation
	{
		// @property (assign, nonatomic) CLLocationDirection movingDirection;
		[Export("movingDirection")]
		double MovingDirection { get; set; }

		// -(void)addMoveAnimationWithKeyCoordinates:(CLLocationCoordinate2D *)coordinates count:(NSUInteger)count withDuration:(CGFloat)duration withName:(NSString *)name completeCallback:(void (^)(BOOL))completeCallback;
		[Export("addMoveAnimationWithKeyCoordinates:count:withDuration:withName:completeCallback:")]
		unsafe void AddMoveAnimationWithKeyCoordinates(CLLocationCoordinate2D coordinates, nuint count, nfloat duration, string name, Action<bool> completeCallback);

		// -(NSArray<MAAnnotationMoveAnimation *> *)allMoveAnimations;
		[Export("allMoveAnimations")]
		//[Verify(MethodToProperty)]
		MAAnnotationMoveAnimation[] AllMoveAnimations { get; }
	}

	public interface IMAAnimatableAnnotation { }

	// @interface MAPinAnnotationView : MAAnnotationView
	[BaseType(typeof(MAAnnotationView))]
	interface MAPinAnnotationView
	{
		// @property (nonatomic) MAPinAnnotationColor pinColor;
		[Export("pinColor", ArgumentSemantic.Assign)]
		MAPinAnnotationColor PinColor { get; set; }

		// @property (nonatomic) BOOL animatesDrop;
		[Export("animatesDrop")]
		bool AnimatesDrop { get; set; }
	}

	// @interface MAOverlayPathRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MAOverlayPathRenderer
	{
		// @property (retain) UIColor * fillColor;
		[Export("fillColor", ArgumentSemantic.Retain)]
		UIColor FillColor { get; set; }

		// @property (retain) UIColor * strokeColor;
		[Export("strokeColor", ArgumentSemantic.Retain)]
		UIColor StrokeColor { get; set; }

		// @property CGFloat lineWidth;
		[Export("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property MALineJoinType lineJoinType;
		[Export("lineJoinType", ArgumentSemantic.Assign)]
		MALineJoinType LineJoinType { get; set; }

		// @property MALineCapType lineCapType;
		[Export("lineCapType", ArgumentSemantic.Assign)]
		MALineCapType LineCapType { get; set; }

		// @property CGFloat miterLimit;
		[Export("miterLimit")]
		nfloat MiterLimit { get; set; }

		// @property BOOL lineDash;
		[Export("lineDash")]
		bool LineDash { get; set; }
	}

	// @interface MACircleRenderer : MAOverlayPathRenderer
	[BaseType(typeof(MAOverlayPathRenderer))]
	interface MACircleRenderer
	{
		// @property (readonly, nonatomic) MACircle * circle;
		[Export("circle")]
		MACircle Circle { get; }

		// -(instancetype)initWithCircle:(MACircle *)circle;
		[Export("initWithCircle:")]
		IntPtr Constructor(MACircle circle);

		// -(void)setNeedsUpdate;
		[Export("setNeedsUpdate")]
		void SetNeedsUpdate();
	}

	// @interface MAMultiPoint : MAShape
	[BaseType(typeof(MAShape))]
	interface MAMultiPoint
	{
		// @property (readonly, nonatomic) MAMapPoint * points;
		[Export("points")]
		unsafe MAMapPoint Points { get; }

		// @property (readonly, nonatomic) NSUInteger pointCount;
		[Export("pointCount")]
		nuint PointCount { get; }

		// -(void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
		[Export("getCoordinates:range:")]
		unsafe void GetCoordinates(CLLocationCoordinate2D coords, NSRange range);
	}

	// @interface MAPolygon : MAMultiPoint <MAOverlay>
	[BaseType(typeof(MAMultiPoint))]
	interface MAPolygon 
	{
		// +(instancetype)polygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export("polygonWithCoordinates:count:")]
		unsafe MAPolygon PolygonWithCoordinates(CLLocationCoordinate2D coords, nuint count);

		// +(instancetype)polygonWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export("polygonWithPoints:count:")]
		unsafe MAPolygon PolygonWithPoints(MAMapPoint points, nuint count);
	}

	// @interface MAPolygonRenderer : MAOverlayPathRenderer
	[BaseType(typeof(MAOverlayPathRenderer))]
	interface MAPolygonRenderer
	{
		// @property (readonly, nonatomic) MAPolygon * polygon;
		[Export("polygon")]
		MAPolygon Polygon { get; }

		// -(instancetype)initWithPolygon:(MAPolygon *)polygon;
		[Export("initWithPolygon:")]
		IntPtr Constructor(MAPolygon polygon);
	}

	// @interface MAPolyline : MAMultiPoint <MAOverlay>
	[BaseType(typeof(MAMultiPoint))]
	interface MAPolyline 
	{
		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export("polylineWithPoints:count:")]
		unsafe MAPolyline PolylineWithPoints(MAMapPoint points, nuint count);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export("polylineWithCoordinates:count:")]
		unsafe MAPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count);
	}

	// @interface MAPolylineRenderer : MAOverlayPathRenderer
	[BaseType(typeof(MAOverlayPathRenderer))]
	interface MAPolylineRenderer
	{
		// @property (readonly, nonatomic) MAPolyline * polyline;
		[Export("polyline")]
		MAPolyline Polyline { get; }

		// -(instancetype)initWithPolyline:(MAPolyline *)polyline;
		[Export("initWithPolyline:")]
		IntPtr Constructor(MAPolyline polyline);
	}

	// @interface MAGeodesicPolyline : MAPolyline
	[BaseType(typeof(MAPolyline))]
	interface MAGeodesicPolyline
	{
		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count;
		[Static]
		[Export("polylineWithPoints:count:")]
		unsafe MAGeodesicPolyline PolylineWithPoints(MAMapPoint points, nuint count);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static]
		[Export("polylineWithCoordinates:count:")]
		unsafe MAGeodesicPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count);
	}

	// @interface MAMultiPolyline : MAPolyline
	[BaseType(typeof(MAPolyline))]
	interface MAMultiPolyline
	{
		// @property (readonly, nonatomic, strong) NSArray * drawStyleIndexes;
		[Export("drawStyleIndexes", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] DrawStyleIndexes { get; }

		// +(instancetype)polylineWithPoints:(MAMapPoint *)points count:(NSUInteger)count drawStyleIndexes:(NSArray *)drawStyleIndexes;
		[Static]
		[Export("polylineWithPoints:count:drawStyleIndexes:")]
		//[Verify(StronglyTypedNSArray)]
		unsafe MAMultiPolyline PolylineWithPoints(MAMapPoint points, nuint count, NSObject[] drawStyleIndexes);

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count drawStyleIndexes:(NSArray *)drawStyleIndexes;
		[Static]
		[Export("polylineWithCoordinates:count:drawStyleIndexes:")]
		//[Verify(StronglyTypedNSArray)]
		unsafe MAMultiPolyline PolylineWithCoordinates(CLLocationCoordinate2D coords, nuint count, NSObject[] drawStyleIndexes);
	}

	// @interface MAMultiTexturePolylineRenderer : MAPolylineRenderer
	[BaseType(typeof(MAPolylineRenderer))]
	interface MAMultiTexturePolylineRenderer
	{
		// @property (readonly, nonatomic) MAMultiPolyline * multiPolyline;
		[Export("multiPolyline")]
		MAMultiPolyline MultiPolyline { get; }

		// @property (readonly, nonatomic, strong) NSArray * strokeTextureIDs;
		[Export("strokeTextureIDs", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] StrokeTextureIDs { get; }

		// -(instancetype)initWithMultiPolyline:(MAMultiPolyline *)multiPolyline;
		[Export("initWithMultiPolyline:")]
		IntPtr Constructor(MAMultiPolyline multiPolyline);

		// -(BOOL)loadStrokeTextureImages:(NSArray *)textureImages;
		[Export("loadStrokeTextureImages:")]
		//[Verify(StronglyTypedNSArray)]
		bool LoadStrokeTextureImages(NSObject[] textureImages);
	}

	// @interface MAMultiColoredPolylineRenderer : MAPolylineRenderer
	[BaseType(typeof(MAPolylineRenderer))]
	interface MAMultiColoredPolylineRenderer
	{
		// @property (readonly, nonatomic) MAMultiPolyline * multiPolyline;
		[Export("multiPolyline")]
		MAMultiPolyline MultiPolyline { get; }

		// @property (nonatomic, strong) NSArray * strokeColors;
		[Export("strokeColors", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] StrokeColors { get; set; }

		// @property (getter = isGradient, nonatomic) BOOL gradient;
		[Export("gradient")]
		bool Gradient { [Bind("isGradient")] get; set; }

		// -(instancetype)initWithMultiPolyline:(MAMultiPolyline *)multiPolyline;
		[Export("initWithMultiPolyline:")]
		IntPtr Constructor(MAMultiPolyline multiPolyline);
	}

	// @interface MAGroundOverlay : MAShape <MAOverlay>
	[BaseType(typeof(MAShape))]
	interface MAGroundOverlay 
	{
		// @property (readonly, nonatomic) UIImage * icon;
		[Export("icon")]
		UIImage Icon { get; }

		// @property (nonatomic) CGFloat alpha;
		[Export("alpha")]
		nfloat Alpha { get; set; }

		// @property (readonly, nonatomic) CGFloat zoomLevel;
		[Export("zoomLevel")]
		nfloat ZoomLevel { get; }

		// @property (readonly, nonatomic) MACoordinateBounds bounds;
		[Export("bounds")]
		MACoordinateBounds Bounds { get; }

		// +(instancetype)groundOverlayWithBounds:(MACoordinateBounds)bounds icon:(UIImage *)icon;
		[Static]
		[Export("groundOverlayWithBounds:icon:")]
		MAGroundOverlay GroundOverlayWithBounds(MACoordinateBounds bounds, UIImage icon);

		// +(instancetype)groundOverlayWithCoordinate:(CLLocationCoordinate2D)coordinate zoomLevel:(CGFloat)zoomLevel icon:(UIImage *)icon;
		[Static]
		[Export("groundOverlayWithCoordinate:zoomLevel:icon:")]
		MAGroundOverlay GroundOverlayWithCoordinate(CLLocationCoordinate2D coordinate, nfloat zoomLevel, UIImage icon);
	}

	// @interface MAGroundOverlayRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MAGroundOverlayRenderer
	{
		// @property (readonly, nonatomic) MAGroundOverlay * groundOverlay;
		[Export("groundOverlay")]
		MAGroundOverlay GroundOverlay { get; }

		// -(instancetype)initWithGroundOverlay:(MAGroundOverlay *)groundOverlay;
		[Export("initWithGroundOverlay:")]
		IntPtr Constructor(MAGroundOverlay groundOverlay);
	}

	// @interface MATileOverlay : NSObject <MAOverlay>
	[BaseType(typeof(NSObject))]
	interface MATileOverlay
	{
		// @property (readonly) CGSize tileSize;
		[Export("tileSize")]
		CGSize TileSize { get; }

		// @property NSInteger minimumZ;
		[Export("minimumZ")]
		nint MinimumZ { get; set; }

		// @property NSInteger maximumZ;
		[Export("maximumZ")]
		nint MaximumZ { get; set; }

		// @property (readonly) NSString * URLTemplate;
		[Export("URLTemplate")]
		string URLTemplate { get; }

		// @property (nonatomic) BOOL canReplaceMapContent;
		[Export("canReplaceMapContent")]
		bool CanReplaceMapContent { get; set; }

		// @property (nonatomic) MAMapRect boundingMapRect;
		[Export("boundingMapRect", ArgumentSemantic.Assign)]
		MAMapRect BoundingMapRect { get; set; }

		// -(id)initWithURLTemplate:(NSString *)URLTemplate;
		[Export("initWithURLTemplate:")]
		IntPtr Constructor(string URLTemplate);
	}

	// @interface MATileOverlayRenderer : MAOverlayRenderer
	[BaseType(typeof(MAOverlayRenderer))]
	interface MATileOverlayRenderer
	{
		// @property (readonly, nonatomic) MATileOverlay * tileOverlay;
		[Export("tileOverlay")]
		MATileOverlay TileOverlay { get; }

		// -(instancetype)initWithTileOverlay:(MATileOverlay *)tileOverlay;
		[Export("initWithTileOverlay:")]
		IntPtr Constructor(MATileOverlay tileOverlay);

		// -(void)reloadData;
		[Export("reloadData")]
		void ReloadData();
	}

	// @interface MAHeatMapNode : NSObject
	[BaseType(typeof(NSObject))]
	interface MAHeatMapNode
	{
		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; set; }

		// @property (assign, nonatomic) float intensity;
		[Export("intensity")]
		float Intensity { get; set; }
	}

	// @interface MAHeatMapGradient : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface MAHeatMapGradient : INSCopying
	{
		// @property (readonly, nonatomic) NSArray * colors;
		[Export("colors")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Colors { get; }

		// @property (readonly, nonatomic) NSArray * startPoints;
		[Export("startPoints")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] StartPoints { get; }

		// -(instancetype)initWithColor:(NSArray *)colors andWithStartPoints:(NSArray *)startPoints;
		[Export("initWithColor:andWithStartPoints:")]
		//[Verify(StronglyTypedNSArray), Verify(StronglyTypedNSArray)]
		IntPtr Constructor(NSObject[] colors, NSObject[] startPoints);
	}

	// @interface MAHeatMapTileOverlay : MATileOverlay
	[BaseType(typeof(MATileOverlay))]
	interface MAHeatMapTileOverlay
	{
		// @property (nonatomic, strong) NSArray * data;
		[Export("data", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Data { get; set; }

		// @property (assign, nonatomic) NSInteger radius;
		[Export("radius")]
		nint Radius { get; set; }

		// @property (assign, nonatomic) CGFloat opacity;
		[Export("opacity")]
		nfloat Opacity { get; set; }

		// @property (nonatomic, strong) MAHeatMapGradient * gradient;
		[Export("gradient", ArgumentSemantic.Strong)]
		MAHeatMapGradient Gradient { get; set; }

		// @property (assign, nonatomic) BOOL allowRetinaAdapting;
		[Export("allowRetinaAdapting")]
		bool AllowRetinaAdapting { get; set; }
	}

	// @interface MATouchPoi : NSObject
	[BaseType(typeof(NSObject))]
	interface MATouchPoi
	{
		// @property (readonly, copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export("coordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Coordinate { get; }

		// @property (readonly, copy, nonatomic) NSString * uid;
		[Export("uid")]
		string Uid { get; }
	}

	// @interface MAOfflineItem : NSObject
	[BaseType(typeof(NSObject))]
	interface MAOfflineItem
	{
		// @property (readonly, copy, nonatomic) NSString * name;
		[Export("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * jianpin;
		[Export("jianpin")]
		string Jianpin { get; }

		// @property (readonly, copy, nonatomic) NSString * pinyin;
		[Export("pinyin")]
		string Pinyin { get; }

		// @property (readonly, copy, nonatomic) NSString * adcode;
		[Export("adcode")]
		string Adcode { get; }

		// @property (readonly, assign, nonatomic) long long size;
		[Export("size")]
		long Size { get; }

		// @property (readonly, assign, nonatomic) MAOfflineItemStatus itemStatus;
		[Export("itemStatus", ArgumentSemantic.Assign)]
		MAOfflineItemStatus ItemStatus { get; }

		// @property (readonly, assign, nonatomic) long long downloadedSize;
		[Export("downloadedSize")]
		long DownloadedSize { get; }
	}

	// @interface MAOfflineCity : MAOfflineItem
	[BaseType(typeof(MAOfflineItem))]
	interface MAOfflineCity
	{
		// @property (readonly, copy, nonatomic) NSString * cityCode;
		[Export("cityCode")]
		string CityCode { get; }

		// @property (readonly, copy, nonatomic) NSString * cityName __attribute__((deprecated("use name instead")));
		[Export("cityName")]
		string CityName { get; }

		// @property (readonly, copy, nonatomic) NSString * urlString __attribute__((deprecated("Not supported in future version")));
		[Export("urlString")]
		string UrlString { get; }

		// @property (readonly, assign, nonatomic) MAOfflineCityStatus status __attribute__((deprecated("use itemStatus instead")));
		[Export("status", ArgumentSemantic.Assign)]
		MAOfflineCityStatus Status { get; }
	}

	// @interface MAOfflineItemCommonCity : MAOfflineCity
	[BaseType(typeof(MAOfflineCity))]
	interface MAOfflineItemCommonCity
	{
		// @property (nonatomic, weak) MAOfflineItem * province;
		[Export("province", ArgumentSemantic.Weak)]
		MAOfflineItem Province { get; set; }
	}

	// @interface MAOfflineProvince : MAOfflineItem
	[BaseType(typeof(MAOfflineItem))]
	interface MAOfflineProvince
	{
		// @property (readonly, nonatomic, strong) NSArray * cities;
		[Export("cities", ArgumentSemantic.Strong)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Cities { get; }
	}

	// @interface MAOfflineItemNationWide : MAOfflineCity
	[BaseType(typeof(MAOfflineCity))]
	interface MAOfflineItemNationWide
	{
	}

	// @interface MAOfflineItemMunicipality : MAOfflineCity
	[BaseType(typeof(MAOfflineCity))]
	interface MAOfflineItemMunicipality
	{
	}

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern NSString *const MAOfflineMapErrorDomain;
	//}

	// typedef void (^MAOfflineMapDownloadBlock)(MAOfflineItem *, MAOfflineMapDownloadStatus, id);
	delegate void MAOfflineMapDownloadBlock(MAOfflineItem arg0, MAOfflineMapDownloadStatus arg1, NSObject arg2);

	// typedef void (^MAOfflineMapNewestVersionBlock)(BOOL);
	delegate void MAOfflineMapNewestVersionBlock(bool arg0);

	// @interface MAOfflineMap : NSObject
	[BaseType(typeof(NSObject))]
	interface MAOfflineMap
	{
		// +(MAOfflineMap *)sharedOfflineMap;
		[Static]
		[Export("sharedOfflineMap")]
		//[Verify(MethodToProperty)]
		MAOfflineMap SharedOfflineMap { get; }

		// @property (readonly, nonatomic) NSArray * provinces;
		[Export("provinces")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Provinces { get; }

		// @property (readonly, nonatomic) NSArray * municipalities;
		[Export("municipalities")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Municipalities { get; }

		// @property (readonly, nonatomic) MAOfflineItemNationWide * nationWide;
		[Export("nationWide")]
		MAOfflineItemNationWide NationWide { get; }

		// @property (readonly, nonatomic) NSArray * cities;
		[Export("cities")]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Cities { get; }

		// @property (readonly, nonatomic) NSString * version;
		[Export("version")]
		string Version { get; }

		// -(void)setupWithCompletionBlock:(void (^)(BOOL))block;
		[Export("setupWithCompletionBlock:")]
		void SetupWithCompletionBlock(Action<bool> block);

		// -(void)downloadItem:(MAOfflineItem *)item shouldContinueWhenAppEntersBackground:(BOOL)shouldContinueWhenAppEntersBackground downloadBlock:(MAOfflineMapDownloadBlock)downloadBlock;
		[Export("downloadItem:shouldContinueWhenAppEntersBackground:downloadBlock:")]
		void DownloadItem(MAOfflineItem item, bool shouldContinueWhenAppEntersBackground, MAOfflineMapDownloadBlock downloadBlock);

		// -(BOOL)isDownloadingForItem:(MAOfflineItem *)item;
		[Export("isDownloadingForItem:")]
		bool IsDownloadingForItem(MAOfflineItem item);

		// -(void)pauseItem:(MAOfflineItem *)item;
		[Export("pauseItem:")]
		void PauseItem(MAOfflineItem item);

		// -(void)deleteItem:(MAOfflineItem *)item;
		[Export("deleteItem:")]
		void DeleteItem(MAOfflineItem item);

		// -(void)cancelAll;
		[Export("cancelAll")]
		void CancelAll();

		// -(void)clearDisk;
		[Export("clearDisk")]
		void ClearDisk();

		// -(void)checkNewestVersion:(MAOfflineMapNewestVersionBlock)newestVersionBlock;
		[Export("checkNewestVersion:")]
		void CheckNewestVersion(MAOfflineMapNewestVersionBlock newestVersionBlock);
	}
}
