#!/usr/bin/env python
# -*- coding: utf-8 -*-
# **********************************************************\
#       Created:     2024-3-14   10:01
#       Filename:    CodeSync.py
#       Author:   ______
#                    / /  (_)
#                   / /_  /\____  ____  __   ______
#                  / __ \/ / __ \/ __ \/ /  / /
#                 / /_/ / / / / / / / / /__/ /
#                /_____/_/_/ /_/_/ /_/\___  /
#               ========== ______________/ /
#                          \______________/
#
#       Email:       Binny@vip.163.com
#       Group:       SP
#       Create By:   Binny
#       Purpose:     对涉及到的文件进行替换，最新修改的文件进行同步
#       Copyright:   FHome(C) 2006 - All Rights Reserved
#       LastModify:  2009-9-14
# **********************************************************/

import os
# 当 dotnet 系统经过改动以后，请执行这个操作
from BnPlatform.BinnyBase import *
code_rows = bnGetFileRows(filename='Microsoft.CodeAnalysis.CSharp.Syntax.txt')
code_python = []
indent = 4 * ' '

err_file = 'Microsoft.CodeAnalysis.CSharp.Syntax.Error.txt'
if os.path.exists(err_file):
    code_error_rows = bnGetFileRows(err_file)
else:
    code_error_rows = []

def IsContainSymbols(text, symbols):
    for s in symbols:
        if not s in text:
            return False
    return True
        
def have_Identifier(node_Syntax):
    for row in code_error_rows:
        if IsContainSymbols(row, ['CS1061', node_Syntax, 'Identifier']):
            return False
    return True
            
for row in code_rows[1:]:
    code = row[3:].strip()
    if not code:
        continue
    if not code.endswith('Syntax'):
        continue
    if not code_python:
        code_python.append('#region')
        code_python.append('')
        code_python.append(f'if (nodeType == typeof({code}))')
    else:
        code_python.append(f'else if (nodeType == typeof({code}))')
    code_python.append('{')
    code_python.append(indent + f'{code} node_Syntax = node as {code};')
    if have_Identifier(code):
        code_python.append(indent + f'desc = node_Syntax.Identifier.Text;')
    else:
        code_python.append(indent + f'desc = "{code}";')
    code_python.append('}')
code_python.append('else')
code_python.append(indent + 'desc = $"UnknowType: {node.GetType()}";')
code_python.append('')
code_python.append('#endregion')
print(indent*2 + f'\n{indent*2}'.join(code_python))