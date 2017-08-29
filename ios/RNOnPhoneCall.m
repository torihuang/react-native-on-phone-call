
#import "RNOnPhoneCall.h"

@implementation RNOnPhoneCall

RCT_EXPORT_MODULE()
- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
- (bool) isTablet
{
  return [[UIDevice currentDevice] userInterfaceIdiom] == UIUserInterfaceIdiomPad;
}

@end
