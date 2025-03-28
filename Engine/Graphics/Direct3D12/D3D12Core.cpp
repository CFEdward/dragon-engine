#include "D3D12Core.h"


namespace dragon::graphics::d3d12::core {

namespace {

ID3D12Device10* main_device;

} // anonymous namespace

bool initialize()
{
	// determine which adapter (i.e. graphics card) to use
	// determine what is the maximum feature level that is supported
	// create a ID3D12Device (this is a virtual adapter)
}

}
