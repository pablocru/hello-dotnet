#!/bin/bash -e

# --- Variables ---

if [ "$#" -ne 4 ]; then
  echo "Error: Invalid number of arguments."
  echo "Usage: $0 <number> <category> <name> <type>"
  echo "Example: $0 01 web hello-world console"
  exit 1
fi

NUMBER="$1"
CATEGORY="$2"
NAME="$3"
TYPE="$4"

case "$TYPE" in
  console|classlib|webapi|xunit)
    ;;
  *)
    echo "Error: Unexpected type '$TYPE'. It must be: console, classlib, webapi, xunit"
    exit 1
    ;;
esac

WORKSHOP_DIR="workshops/${NUMBER}-${CATEGORY}/${NAME}"
WORKSHOP_ID="${NUMBER}-${CATEGORY}/${NAME}"

# --- Functions ---

create_workshop() {
  mkdir -p "$WORKSHOP_DIR"
  cd "$WORKSHOP_DIR"
  dotnet new ${TYPE} --use-program-main
  dotnet build
  cd -
}

add_to_solution() {
  dotnet sln add $WORKSHOP_DIR
}

# --- Program ---

echo "Creating workshop ${WORKSHOP_ID}..."
create_workshop
echo

echo "Adding ${WORKSHOP_ID} to solution file..."
add_to_solution
echo

echo "✅ Workshop ${WORKSHOP_ID} ready!"
