cmake_minimum_required(VERSION 3.25)
project(H7O3 C)

set(CMAKE_C_STANDARD 90)

include_directories(.)

add_executable(H7O3
        dugum.c
        dugum.h ikiliagac.c ikiliagac.h)
