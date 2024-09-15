#pragma once
#include "CommonHeaders.h"

#if !defined(SHIPPING)
namespace dragon::content {

bool load_game();
void unload_game();

}
#endif