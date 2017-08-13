# easy\_get\_iplayer\_2.0
### Basic GUI for downloading BBC iPlayer TV programmes using get\_iplayer

## Features
- Info fetching and downloading from URL
- Configurable download quality

## Notes
- Download size estimates are often wrong, especially with 50fps downloads. The estimates are calculated by get\_iplayer, so I cannot fix this, nor can they. It is simply a (very rough) estimate.
- Long pauses may be experienced during use of the program. This is due to some get\_iplayer processes taking some time to start, or by iPlayer being slow. Little can be done about this, but simply wait and the process should start.
- The program may cease working completely. This is usually due to the BBC changing iPlayer and get\_iplayer not supporting these changes. get\_iplayer may be updated fairly quickly, so simply check for an update, and if this program is not compatible with the new version, simply file an issue and I will look into it.
- Only 50fps 720p is available. This is due to the 25fps 720p stream being removed by the BBC. Unless another stream becomes available, I cannot fix this.
- Available download qualities are: 720p 50fps, 540p 25fps and 396p 25fps.

## Download
Downloads can be found [here](https://github.com/jamerst/easy_get_iplayer_2.0/releases)

## Attributions
- All downloading and info fetching provided by [get\_iplayer](https://github.com/get-iplayer/get_iplayer).
