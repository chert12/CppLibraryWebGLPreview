cmake_minimum_required(VERSION 3.23)
project(webGLC__Lib)

set(CMAKE_CXX_STANDARD 14)

add_library(MathLib SHARED mathBase.h mathBase.cpp)
