#pragma once
#include "CommonHeaders.h"
#include "..\Platform\Window.h"

namespace dragon::graphics {

class surface
{
	
};

struct render_surface
{
	platform::window window{};
	surface surface{};
};

}