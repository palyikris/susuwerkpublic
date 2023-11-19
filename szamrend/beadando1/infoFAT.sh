#!/bin/bash

fatData="$(<FAT.dat)"


if [ $1 == "-lista" ]
then
  echo "$fatData"
fi

if [ $1 == "-szabad" ]
then
  szabad=0
  for block in ${fatData[@]}
  do
    if [ $block == 'S' ]
    then
      let szabad++
    fi
  done
  echo "$szabad"
fi

if [ $1 == "-max" ]
then
  maxRow=0
  currRow=0
  for block in ${fatData[@]}
  do
    if [ $block == 'S' ]
    then
      let currRow++

      if [ $maxRow -lt $currRow ]
      then
        maxRow=$currRow
      fi
    fi

    if [ $block != 'S' ]
    then
      currRow=0
    fi
  done
  echo "$maxRow"
fi

if [ $1 == "-foglal" ]
then
  freeBlocks=$(./infoFAT.sh -max)

  if [ $freeBlocks -lt $2 ]
  then
    echo "Nincs elég tárhely"
  fi

  if [ $freeBlocks -ge $2 ]
  then
    sOccurance=""
    fOccurance=""
    SCounter=0
    s="S"
    f="F"
    space=" "

    while [ $SCounter -lt $2 ]
    do
      sOccurance="$sOccurance$s$space"
      fOccurance="$fOccurance$f$space"
      let SCounter++
    done
    echo "$fatData" | sed "s/${sOccurance}/${fOccurance}/" > FAT.dat
  fi
fi